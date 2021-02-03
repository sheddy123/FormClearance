using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormClearance.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(string url, int Id);
        Task<IEnumerable<T>> GetAllAsync(string url);
        Task<bool> CreateAsync(string url, T objToCreate);
        //Task<bool> PostAsync(string url, T objToCreate);
        Task<bool> UpdateAsync(string url, T objToUpdate);
        Task<bool> DeleteAsync(string url, int Id);
        Task<List<T>> GetAllPartner(string url);
        Task<List<T>> GetAllBundle(string url);
        Task<T> GetAsyncRequest(string url, string username);
        Task<FormClearance.Models.FormClearance> AdminResponse(string url, string username);
    }
    
}
