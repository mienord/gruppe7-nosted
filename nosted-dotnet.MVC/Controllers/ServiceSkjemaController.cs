using nosted_dotnet.MVC.Models.ServiceSkjema;
using Microsoft.AspNetCore.Mvc;


namespace nosted_dotnet.MVC.Controllers
{
	public class ServiceSkjemaController : Controller
	{
		public IActionResult Index()
		{
            var model = new ServiceSkjemaViewModel
            {
                ConsumedHours = 0,
                CreatedDate = new DateTime(2023, 9, 7),
                CustomerCity = "Kristiansand",
                CustomerComment = "Hei og hå, jeg er en kundekommentar",
                CustomerEmail = "customer@thesystem.no",
                CustomerName = "Sattosk Rev",
                CustomerStreet = "Gata 13",
                CustomerTelephoneNumber = "1337",
                CustomerZipcode = "1234",
                FutureMaintenance = "Ingenting å bemerke",
                ImageUrl = "",
                IsAdministrator = false,
                skjemaGroups = new List<ServiceSkjemafieldGroupModel> {
        new ServiceSkjemafieldGroupModel {Name ="Kundeinfo", SkjemaFelt=new List<string>{"Kunde:", "Adresse:", "Email:", "Telefon:", "Ordrenummer:", "Produkttype:", "Årsmodell:", "Service/rep garanti:", "Serienummer:"} },
        new ServiceSkjemafieldGroupModel{ Name="Hva er avtalt med kunden?", SkjemaFelt=new List<string>{ } },
        new ServiceSkjemafieldGroupModel{ Name="Reperasjonsbeskrivelse:", SkjemaFelt=new List<string>{ } },
        new ServiceSkjemafieldGroupModel{ Name="Medgåtte deler:", SkjemaFelt=new List<string>{ } },


        },
                Mechanic = "Espen",
                MechanicComment = "ingen kommentar",
                SerialNumber = "pirepioj123åojå",
                ServiceSkjemaId = 1
            };

            return View(model);
        }
    }
}



