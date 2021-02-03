using FormClearance.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FormClearance.Repository
{
    public class FormRepo : Repository<FormClearance.Models.FormClearance>, IFormRepo
    {
        private readonly IHttpClientFactory _clientFactory;
        public FormRepo(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
    }
}
