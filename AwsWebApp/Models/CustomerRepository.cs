using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AwsWebApp.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer> Get(int id)
        {
            return await _context.Customer.FindAsync(id);
        }

        public async Task Remove(int id)
        {
            var customer = await _context.Customer.FindAsync(id);

            if (customer == null) return;

            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
}