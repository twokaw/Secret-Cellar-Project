using MySql.Data.MySqlClient;
using Shared;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;
using pos_core_api.IORM;

namespace pos_core_api.ORM
{
    public class CustomerNoteORM: ICustomerNoteORM
    {
        readonly DbConn db = new();

        const string CUSTOMERNOTESSQL = @"
          SELECT customernoteid, customerid, notetypeid, note, notedate, notetype 
          FROM v_customernotes
        ";

        public List<CustomerNote> Get()
        {
            MySqlCommand cmd = db.CreateCommand(CUSTOMERNOTESSQL);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                return Fetch(reader);
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public List<CustomerNote> Get(uint customerID)
        {
            MySqlCommand cmd = db.CreateCommand(@$"{CUSTOMERNOTESSQL}
              WHERE customerid = @custid
            ");

            cmd.Parameters.Add(new MySqlParameter("custID", customerID));

            MySqlDataReader reader = cmd.ExecuteReader();
            
            try
            {
                List<CustomerNote> output = Fetch(reader);

                if (output.Count > 0)
                    return output;
                else
                    return null;
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public List<CustomerNote> GetbyType(uint customerTypeID)
        {
            MySqlCommand cmd = db.CreateCommand(@$"{CUSTOMERNOTESSQL}
              WHERE notetypeid = @customertypeid
            ");

            cmd.Parameters.Add(new MySqlParameter("customerTypeID", customerTypeID));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                List<CustomerNote> output = Fetch(reader);

                return output;
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public List<NoteType> GetNoteTypes()
        {
            List<NoteType> output = new();
            
            MySqlCommand cmd = db.CreateCommand(@$"
              SELECT notetypeid, notetype
              FROM   notetype
            ");

            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                    output.Add(new NoteType
                    {
                        Note_Type  = reader.IsDBNull("NoteType") ? "" : reader.GetString("NoteType"),
                        IdNoteType = reader.IsDBNull("NoteTypeID") ? 0 : reader.GetUInt32("NoteTypeID")
                    });

                return output;
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public long Insert(CustomerNote custNote)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO customernote
                ( customerid, notetypeid, note, notedate)
                VALUES 
                ( @customerid, @notetypeid, @note, @notedate)
            ");

            cmd.Parameters.Add(new MySqlParameter("CustomerId", custNote.IdCustomer));
            cmd.Parameters.Add(new MySqlParameter("NoteTypeId", custNote.IdNoteType));
            cmd.Parameters.Add(new MySqlParameter("Note", custNote.Note));
            cmd.Parameters.Add(new MySqlParameter("NoteDate", custNote.NoteDate));

            try
            {
                cmd.ExecuteNonQuery();

                return cmd.LastInsertedId;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public long Update(CustomerNote custNote)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE customernote 
                SET customerid = @customerid,
                    notetypeid = @notetypeid,
                    note       = @note,
                    notedate   = @notedate
                WHERE customernoteid = @customernoteid
            ");
            cmd.Parameters.Add(new MySqlParameter("CustomerNoteID", custNote.IdNote));
            cmd.Parameters.Add(new MySqlParameter("CustomerId", custNote.IdCustomer));
            cmd.Parameters.Add(new MySqlParameter("NoteTypeId", custNote.IdNoteType));
            cmd.Parameters.Add(new MySqlParameter("Note", custNote.Note));
            cmd.Parameters.Add(new MySqlParameter("NoteDate", custNote.NoteDate ));            

            try
            {
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void Delete(uint custNoteID)
        {
            string sqlStatementDesc = @"
                DELETE FROM customernote
                WHERE customernoteid = @custid
            ";

            MySqlCommand cmd = db.CreateCommand(sqlStatementDesc);
            cmd.Parameters.Add(new MySqlParameter("custID", custNoteID));   
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public long InsertNoteType(NoteType noteType)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO notetype
                (notetype)
                VALUES 
                (@notetype)
            ");
            cmd.Parameters.Add(new MySqlParameter("NoteType", noteType.Note_Type));

            try
            {
                cmd.ExecuteNonQuery();

                return cmd.LastInsertedId;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public long UpdateNoteType(NoteType noteType)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE notetype 
                SET notetype = @notetype
                WHERE notetypeid = @notetypeid
            ");
            cmd.Parameters.Add(new MySqlParameter("NoteType", noteType.Note_Type));
            cmd.Parameters.Add(new MySqlParameter("NoteTypeID", noteType.IdNoteType));            

            try
            {
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void DeleteNoteType(uint IdNoteType)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                DELETE FROM notetype 
                WHERE notetypeid = @notetypeid
            ");
            cmd.Parameters.Add(new MySqlParameter("NoteTypeID", IdNoteType));     
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        private static List<CustomerNote> Fetch(MySqlDataReader reader)
        {
            List<CustomerNote> output = new();

            while (reader.Read())
                output.Add(new CustomerNote
                {
                    IdNote = reader.IsDBNull("CustomerNoteID") ? 0 : reader.GetUInt32("CustomerNoteID"),
                    IdCustomer  = reader.IsDBNull("CustomerID") ? 0 : reader.GetUInt32("CustomerID"),
                    Note = reader.IsDBNull("note") ? "" : reader.GetString("note"),
                    NoteDate = reader.IsDBNull("NoteDate") ? System.DateTime.Now : reader.GetDateTime("NoteDate"),
                    Note_Type = reader.IsDBNull("NoteType") ? "" : reader.GetString("NoteType"),
                    IdNoteType = reader.IsDBNull("NoteTypeID") ? 0 : reader.GetUInt32("NoteTypeID")
                });

            return output;
        }
    }
}
