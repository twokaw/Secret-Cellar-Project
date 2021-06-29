using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pos_core_api.IORM
{
    public interface ICustomerNoteORM
    {
        public List<CustomerNote> Get();
        public List<CustomerNote> Get(uint customerID);
        public List<CustomerNote> GetbyType(uint customerTypeID);
        public List<NoteType> GetNoteTypes();
        public long Insert(CustomerNote custNote);
        public long Update(CustomerNote custNote);
        public void Delete(uint custNoteID);
        public long InsertNoteType(NoteType noteType);
        public long UpdateNoteType(NoteType noteType);
        public void DeleteNoteType(uint IdNoteType);

    }

}
