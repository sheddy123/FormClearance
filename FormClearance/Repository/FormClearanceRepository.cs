using FormClearance.Data;
using FormClearance.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormClearance.Repository
{
    public class FormClearanceRepository : IFormClearanceRepository
    {
        private readonly FormClearanceContext _db;
        public FormClearanceRepository(FormClearanceContext db)
        {
            _db = db;
        }
        public bool CreateForm(Models.FormClearance formClearance)
        {
            _db.formClearances.Add(formClearance);
            return Save();
        }

        public bool DeleteForm(Models.FormClearance formClearance)
        {
            _db.formClearances.Remove(formClearance);
            return Save();
        }

        public bool FormExists(string name)
        {
            bool value = _db.formClearances.Any(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool FormExists(int id)
        {
            return _db.formClearances.Any(a => a.Id == id);
        }

        public ICollection<Models.FormClearance> GetForms(string userType)
        {

            return userType == "Network Unit" || userType =="Manager" ? _db.formClearances.Where(c=> (c.Status == "PROCESSING" || c.Status == "UNRESOLVED" || c.Status == "INITIATED" || c.Status == "DECLINED")).OrderBy(a => a.Name).ToList() : _db.formClearances.Where(c =>  c.Status == "UNRESOLVED").OrderBy(a => a.Name).ToList();
        }

        public ICollection<Models.FormClearance> GetArchive(string userType)
        {
            if(userType=="Manager" || userType== "Network Unit")
            {
                return _db.formClearances.Where(c => c.Status == "TREATED" && (c.UserRole == "Network Engineer")).OrderBy(a => a.Name).ToList();
            }
            return _db.formClearances.Where(c => (c.Status == "TREATED" || c.Status == "DECLINED") && c.UserRole=="Admin").OrderBy(a => a.Name).ToList();
        }

        public Models.FormClearance GetForms(int formId)
        {
            return _db.formClearances.FirstOrDefault(a => a.Id.Equals(formId));
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateForm(Models.FormClearance formClearance)
        {
            _db.formClearances.Update(formClearance);
            return Save();
        }
    }
}
