using pos_core_api.IORM;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pos_core_api.ORM.Test
{
    public class CustomerNoteTestORM : ICustomerNoteORM
    {
        public void Delete(uint custNoteID)
        {
            throw new NotImplementedException();
        }

        public void DeleteNoteType(uint IdNoteType)
        {
            throw new NotImplementedException();
        }

        public List<CustomerNote> Get()
        {
            throw new NotImplementedException();
        }

        public List<CustomerNote> Get(uint customerID)
        {
            throw new NotImplementedException();
        }

        public List<CustomerNote> GetbyType(uint customerTypeID)
        {
            throw new NotImplementedException();
        }

        public List<NoteType> GetNoteTypes()
        {
            throw new NotImplementedException();
        }

        public long Insert(CustomerNote custNote)
        {
            throw new NotImplementedException();
        }

        public long InsertNoteType(NoteType noteType)
        {
            throw new NotImplementedException();
        }

        public long Update(CustomerNote custNote)
        {
            throw new NotImplementedException();
        }

        public long UpdateNoteType(NoteType noteType)
        {
            throw new NotImplementedException();
        }
    }
}
