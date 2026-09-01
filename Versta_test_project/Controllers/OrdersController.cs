using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Versta_test_project.Data;
using Versta_test_project.Models;

namespace Versta_test_project.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ILogger<OrdersController> _logger;

        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allOrders = _context.Orders.ToList();
            return View(allOrders);
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SaveOrder(CreateOrderModel form)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", form);
            }

            var newOrder = new OrderModel
            {
                senderCity = form.senderCity,
                senderAddress = form.senderAddress,
                recipientCity = form.recipientCity,
                recipientAddress = form.recipientAddress,
                packageWeight = form.packageWeight.Value,
                collectionDate = form.collectionDate.Value
            };
            _context.Orders.Add(newOrder);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ViewOrderDetails(int id)
        {
            var order = _context.Orders.Find(id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}
