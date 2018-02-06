using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using AwsWebApp.Models;

namespace AwsWebApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<ActionResult> Index()
        {
            var items = await _repository.GetAll();

            return View(items);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }

            await _repository.Add(customer);

            return RedirectToAction("Index");
        }

        /// <exclude />
        [HttpGet]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var item = await _repository.Get(id.Value);
            if (item == null)
            {
                return HttpNotFound();
            }

            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await _repository.Remove(id);

            return RedirectToAction("Index");
        }
    }
}