using Microsoft.AspNetCore.Mvc;
using nosted_dotnet.MVC.Models.ArbeidsProsess;

namespace nosted_dotnet.MVC.Controllers
{
    public class ArbeidsProsessController : Controller
    {
        public IActionResult Index()
        {
            var model = new ArbeidsProsessModel
            {
                WeekBookedService = 39,
                DateRecieved = new DateTime(2019, 5, 8),
                IsCaseDone = true,
                ProductType = "vinsj",
                OrderFromCustomer = "Service, takk",
                //kundeinfo
                CustomerFirstName = "Ola",
                CustomerLastName = "Nordmann",
                CustomerAdress = "Skolegata 3",
                CustomerEmail = "olanord@gmail.com",
                CustomerPhone = "99887766",

                DateAgreedDelivery = new DateTime(2019, 5, 18),
                DateRecievedProduct = new DateTime(2019, 5, 18),
                WithinDateCompletion = new DateTime(2019, 6, 1),
                DateCompletion = new DateTime(2019, 5, 31),
                NumberOfHoursForService = 8,
                OrderNumber = 00933,
                ServiceForm = "uia.no"
            };

            
            return View(model);
        }
    }
}
