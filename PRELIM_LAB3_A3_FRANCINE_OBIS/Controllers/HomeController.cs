using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_A3_FRANCINE_OBIS.Models;
using System.Diagnostics;

namespace PRELIM_LAB3_A3_FRANCINE_OBIS.Controllers
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
            List<customer> customers = new List<customer>
    {
        new customer
        {
            FirstName = "Alice",
            MiddleName = "Be",
            LastName = "Carson",
            BirthDay = new DateTime(1996, 5, 10),
            CustomerId = 11001
        },
        new VIPCustomer
        {
            FirstName = "Bianca",
            MiddleName = "Tuazon",
            LastName = "Saguban",
            BirthDay = new DateTime(2004, 10, 13),
            CustomerId = 21011,
            IsVip = true
        },
        new VIPCustomer
        {
            FirstName = "France",
            MiddleName = "Ramirez",
            LastName = "Obis",
            BirthDay = new DateTime(2004, 11, 13),
            CustomerId = 21001,
            IsVip = true
        },
        new customer
        {
            FirstName = "Bo",
            MiddleName = "Park",
            LastName = "Gum",
            BirthDay = new DateTime(1996, 5, 10),
            CustomerId = 10011
        },
        new customer
        {
            FirstName = "Alice",
            MiddleName = "Bell",
            LastName = "Carson",
            BirthDay = new DateTime(1996, 5, 10),
            CustomerId = 3001
        },
        new VIPCustomer
        {
            FirstName = "Xyrylle",
            MiddleName = "Lasin",
            LastName = "Matiga",
            BirthDay = new DateTime(2004, 8, 30),
            CustomerId = 4011,
            IsVip = true
        },
        new VIPCustomer
        {
            FirstName = "Verna",
            MiddleName = "En",
            LastName = "Cenardo",
            BirthDay = new DateTime(2004, 6, 2),
            CustomerId = 5011,
            IsVip = true
        },
        new customer
        {
            FirstName = "Kathryn",
            MiddleName = "Chandria",
            LastName = "Bernardo",
            BirthDay = new DateTime(1996, 3, 26),
            CustomerId = 6011
        },
        new customer
        {
            FirstName = "Daniel",
            MiddleName = "Ce",
            LastName = "Padilla",
            BirthDay = new DateTime(1995, 4, 26),
            CustomerId = 6012,
        },
        new customer
        {
            FirstName = "Liza",
            MiddleName = "He",
            LastName = "Soberano",
            BirthDay = new DateTime(1998, 1, 4),
            CustomerId = 6013
        }
    };

            ViewBag.CustomerList = customers;
            return View();
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
