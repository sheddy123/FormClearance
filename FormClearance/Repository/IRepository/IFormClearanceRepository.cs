using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormClearance.Repository.IRepository
{
    public interface IFormClearanceRepository
    {
        ICollection<FormClearance.Models.FormClearance> GetForms(string userType);
        ICollection<FormClearance.Models.FormClearance> GetArchive(string userType);
        FormClearance.Models.FormClearance GetForms(int formId);
        bool FormExists(string name);
        bool FormExists(int id);
        bool CreateForm(FormClearance.Models.FormClearance formClearance);
        bool UpdateForm(FormClearance.Models.FormClearance formClearance);
        bool DeleteForm(FormClearance.Models.FormClearance formClearance);

        bool Save();
    }
}

