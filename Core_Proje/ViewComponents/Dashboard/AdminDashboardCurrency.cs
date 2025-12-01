using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminDashboardCurrency:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = XDocument.Load(url);

            var dolarElement = xmlDoc.Descendants("Currency")
                .FirstOrDefault(x => x.Attribute("Kod")?.Value == "USD");

            string dolar = dolarElement?.Element("BanknoteSelling")?.Value ?? "0";

            var euroElement = xmlDoc.Descendants("Currency")
                .FirstOrDefault(x => x.Attribute("Kod")?.Value == "EUR");

            string euro = euroElement?.Element("BanknoteSelling")?.Value ?? "0";

            var sterlinElement = xmlDoc.Descendants("Currency")
                .FirstOrDefault(x => x.Attribute("Kod")?.Value == "GBP");

            string sterlin = sterlinElement?.Element("BanknoteSelling")?.Value ?? "0";

            ViewBag.dolar = dolar;
            ViewBag.euro = euro;
            ViewBag.Sterlin = sterlin;


            return View();
        }
    }
}
