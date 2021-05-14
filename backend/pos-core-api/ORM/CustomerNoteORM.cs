using MySql.Data.MySqlClient;
using Shared;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class CustomerNoteORM
    {
        readonly DbConn db = new DbConn();

        const string CUSTOMERNOTESSQL = @"
          SELECT CustomerNoteID, CustomerID, NoteTypeID, Note, NoteDate, NoteType 
          FROM v_CustomerNotes
        ";

        public List<CustomerNote> Get()
        {
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(CUSTOMERNOTESSQL, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                return Fetch(reader);
            }
            finally
            {
                reader.Close();
                db.CloseConnnection();
            }
        }

        public List<CustomerNote> Get(uint customerID)
        {
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@$"{CUSTOMERNOTESSQL}
              WHERE customerID = @custID
            ", db.Connection());

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
                db.CloseConnnection();
            }
        }

        public List<CustomerNote> GetbyType(uint customerTypeID)
        {
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@$"{CUSTOMERNOTESSQL}
              WHERE NoteTypeID = @customerTypeID
            ", db.Connection());

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
                db.CloseConnnection();
            }
        }

        public List<NoteType> GetNoteTypes()
        {
            List<NoteType> output = new List<NoteType>();
            db.OpenConnection();


            MySqlCommand cmd = new MySqlCommand(@$"
              SELECT NotetypeId, NoteType
              FROM   Notetype
            ", db.Connection());

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
                db.CloseConnnection();
            }
        }

        public long Insert(CustomerNote custNote)
        {
            try
            {
                db.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(@"
                  INSERT INTO CustomerNote
                  ( CustomerId, NoteTypeId, Note, NoteDate)
                  VALUES 
                  ( @CustomerId, @NoteTypeId, @Note, @NoteDate)
                ", db.Connection());

                cmd.Parameters.Add(new MySqlParameter("CustomerId", custNote.IdCustomer));
                cmd.Parameters.Add(new MySqlParameter("NoteTypeId", custNote.IdNoteType));
                cmd.Parameters.Add(new MySqlParameter("Note", custNote.Note));
                cmd.Parameters.Add(new MySqlParameter("NoteDate", custNote.NoteDate));

                cmd.ExecuteNonQuery();

                return cmd.LastInsertedId;
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public long Update(CustomerNote custNote)
        {
            db.OpenConnection();

            try
            {
                string sqlStatementDesc = @"
                 UPDATE customerNote 
                 SET CustomerId = @CustomerId,
                     NoteTypeId = @NoteTypeId,
                     Note       = @Note,
                     NoteDate   = @NoteDate
                 WHERE CustomerNoteID = @CustomerNoteID
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("CustomerNoteID", custNote.IdNote));
                cmd.Parameters.Add(new MySqlParameter("CustomerId", custNote.IdCustomer));
                cmd.Parameters.Add(new MySqlParameter("NoteTypeId", custNote.IdNoteType));
                cmd.Parameters.Add(new MySqlParameter("Note", custNote.Note));
                cmd.Parameters.Add(new MySqlParameter("NoteDate", custNote.NoteDate ));

                return cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public void Delete(uint custNoteID)
        {
            db.OpenConnection();
            try
            {
                string sqlStatementDesc = @"
                  DELETE FROM CustomerNote
                  WHERE CustomerNoteID = @custID
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("custID", custNoteID));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public long InsertNoteType(NoteType noteType)
        {
            try
            {
                db.OpenConnection();

                string sqlStatementDesc = @"
                  INSERT INTO Notetype
                  (NoteType)
                  VALUES 
                  (@NoteType)
                ";
                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("NoteType", noteType.Note_Type));
                cmd.ExecuteNonQuery();

                return cmd.LastInsertedId;
            }
            finally
            {
                db.CloseConnnection();
            }
        }
        public long UpdateNoteType(NoteType noteType)
        {
            db.OpenConnection();

            try
            {
                string sqlStatementDesc = @"
                 UPDATE Notetype 
                 SET NoteType = @NoteType
                 WHERE NoteTypeID = @NoteTypeID
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("NoteType", noteType.Note_Type));
                cmd.Parameters.Add(new MySqlParameter("NoteTypeID", noteType.IdNoteType));

                return cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public void DeleteNoteType(uint IdNoteType)
        {
            db.OpenConnection();
            try
            {
                string sqlStatementDesc = @"
                  DELETE FROM Notetype 
                  WHERE NoteTypeID = @NoteTypeID
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("NoteTypeID", IdNoteType));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        private static List<CustomerNote> Fetch(MySqlDataReader reader)
        {
            List<CustomerNote> output = new List<CustomerNote>();

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
