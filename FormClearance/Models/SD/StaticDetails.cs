using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormClearance.Models.SD
{
    public class StaticDetails
    {
        public const string ApiBasePath = "https://localhost:44304/Api/FormClearance";
        public const string CreateForm = ApiBasePath + "/CreateForm";
        public const string ProcessForm = ApiBasePath + "/ProcessForm";
        public const string UpdateForm = ApiBasePath + "/UpdateForm";
        public const string AdminResponse = ApiBasePath + "/AdminResponse";
        public const string DeleteResponse = ApiBasePath + "/DeleteResponse/";
    }
}
