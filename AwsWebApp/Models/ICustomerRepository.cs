using System.Collections.Generic;
using System.Threading.Tasks;

namespace AwsWebApp.Models
{
    public interface ICustomerRepository
    {
        Task Add(Customer customer);
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> Get(int id);
        Task Remove(int id);
    }
}