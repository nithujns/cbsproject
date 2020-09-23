using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CBSProject.Models;

namespace CBSProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Invoice> invoiceList = new List<Invoice>();
            //create dummy list
            var invoice1 = new Invoice
            {
                InvoiceNumber = 12345,
                InvoiceDate = DateTime.Now,
                DueDate = DateTime.Now,
                Terms = "Lorem ipsum dolor sit amet",
                Description = "Discount of $100 if aid before 05/10/2016",
                AmountDue = 100,
                Total = 100,
                PONumber = 36466
            };
            invoiceList.Add(invoice1);
            var invoice2 = new Invoice
            {
                InvoiceNumber = 13452,
                InvoiceDate = DateTime.Now,
                DueDate = DateTime.Now,
                Terms = "Lorem ipsum dolor sit amet",
                Description = "Discount of $100 if aid before 05/10/2016",
                AmountDue = 200,
                Total = 200,
                PONumber = 36467
            };
            invoiceList.Add(invoice2);
            var invoice3 = new Invoice
            {
                InvoiceNumber = 79456,
                InvoiceDate = DateTime.Now,
                DueDate = DateTime.Now,
                Terms = "Lorem ipsum dolor sit amet",
                Description = "Discount of $100 if aid before 05/10/2016",
                AmountDue = 300,
                Total = 300,
                PONumber = 36468
            };
            invoiceList.Add(invoice3);
            var invoice4 = new Invoice
            {
                InvoiceNumber = 44612,
                InvoiceDate = DateTime.Now,
                DueDate = DateTime.Now,
                Terms = "Lorem ipsum dolor sit amet",
                Description = "Discount of $100 if aid before 05/10/2016",
                AmountDue = 400,
                Total = 400,
                PONumber = 36469
            };
            invoiceList.Add(invoice4);

            return View(invoiceList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
