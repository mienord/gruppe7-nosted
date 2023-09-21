namespace nosted_dotnet.MVC.Models.ServiceSkjema
{
    public class ServiceSkjemaViewModel
    {
        public string Mechanic { get; set; }
        public bool IsAdministrator { get; set; }
        public string SerialNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal ConsumedHours { get; set; }
        public string ImageUrl { get; set; }
        public string MechanicComment { get; set; }
        public string CustomerComment { get; set; }

        public string FutureMaintenance { get; set; }
        public int ServiceSkjemaId { get; set; }
        public List<ServiceSkjemafieldGroupModel> skjemaGroups { get; set; }

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipcode { get; set; }
        public string CustomerTelephoneNumber { get; set; }

    }

    public class ServiceSkjemafieldGroupModel
    {
        public string Name { get; set; }

        public List<string> SkjemaFelt { get; set; }
    }

}


