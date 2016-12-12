using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Angular2DXWebpackCore.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }

        [HttpGet("[action]")]
        public IEnumerable<Order> Orders()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order() { OrderID = 10248, OrderDate = new DateTime(1996, 07, 04), CustomerName = "Paul Henriot", ShipCountry = "France", ShipCity = "Reims" });
            orders.Add(new Order() { OrderID = 10249, OrderDate = new DateTime(1996, 07, 05), CustomerName = "Karin Josephs", ShipCountry = "Germany", ShipCity = "Münster" });
            orders.Add(new Order() { OrderID = 10250, OrderDate = new DateTime(1996, 07, 08), CustomerName = "Mario Pontes", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" });
            orders.Add(new Order() { OrderID = 10251, OrderDate = new DateTime(1996, 07, 08), CustomerName = "Mary Saveley", ShipCountry = "France", ShipCity = "Lyon" });
            orders.Add(new Order() { OrderID = 10252, OrderDate = new DateTime(1996, 07, 09), CustomerName = "Pascale Cartrain", ShipCountry = "Belgium", ShipCity = "Charleroi" });
            orders.Add(new Order() { OrderID = 10253, OrderDate = new DateTime(1996, 07, 10), CustomerName = "Mario Pontes", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" });
            orders.Add(new Order() { OrderID = 10254, OrderDate = new DateTime(1996, 07, 11), CustomerName = "Yang Wang", ShipCountry = "Switzerland", ShipCity = "Bern" });
            orders.Add(new Order() { OrderID = 10255, OrderDate = new DateTime(1996, 07, 12), CustomerName = "Michael Holz", ShipCountry = "Switzerland", ShipCity = "Genève" });
            orders.Add(new Order() { OrderID = 10256, OrderDate = new DateTime(1996, 07, 15), CustomerName = "Paula Parente", ShipCountry = "Brazil", ShipCity = "Resende" });
            orders.Add(new Order() { OrderID = 10257, OrderDate = new DateTime(1996, 07, 16), CustomerName = "Carlos Hernández", ShipCountry = "Venezuela", ShipCity = "San Cristóbal" });
            orders.Add(new Order() { OrderID = 10258, OrderDate = new DateTime(1996, 07, 17), CustomerName = "Roland Mendel", ShipCountry = "Austria", ShipCity = "Graz" });
            orders.Add(new Order() { OrderID = 10259, OrderDate = new DateTime(1996, 07, 18), CustomerName = "Francisco Chang", ShipCountry = "Mexico", ShipCity = "México D.F." });
            orders.Add(new Order() { OrderID = 10260, OrderDate = new DateTime(1996, 07, 19), CustomerName = "Henriette Pfalzheim", ShipCountry = "Germany", ShipCity = "Köln" });
            orders.Add(new Order() { OrderID = 10261, OrderDate = new DateTime(1996, 07, 19), CustomerName = "Bernardo Batista", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" });
            orders.Add(new Order() { OrderID = 10262, OrderDate = new DateTime(1996, 07, 22), CustomerName = "Paula Wilson", ShipCountry = "USA", ShipCity = "Albuquerque" });
            orders.Add(new Order() { OrderID = 10263, OrderDate = new DateTime(1996, 07, 23), CustomerName = "Roland Mendel", ShipCountry = "Austria", ShipCity = "Graz" });
            orders.Add(new Order() { OrderID = 10264, OrderDate = new DateTime(1996, 07, 24), CustomerName = "Maria Larsson", ShipCountry = "Sweden", ShipCity = "Bräcke" });
            orders.Add(new Order() { OrderID = 10265, OrderDate = new DateTime(1996, 07, 25), CustomerName = "Frédérique Citeaux", ShipCountry = "France", ShipCity = "Strasbourg" });
            orders.Add(new Order() { OrderID = 10266, OrderDate = new DateTime(1996, 07, 26), CustomerName = "Pirkko Koskitalo", ShipCountry = "Finland", ShipCity = "Oulu" });
            orders.Add(new Order() { OrderID = 10267, OrderDate = new DateTime(1996, 07, 29), CustomerName = "Peter Franken", ShipCountry = "Germany", ShipCity = "München" });
            orders.Add(new Order() { OrderID = 10268, OrderDate = new DateTime(1996, 07, 30), CustomerName = "Manuel Pereira", ShipCountry = "Venezuela", ShipCity = "Caracas" });
            orders.Add(new Order() { OrderID = 10269, OrderDate = new DateTime(1996, 07, 31), CustomerName = "Karl Jablonski", ShipCountry = "USA", ShipCity = "Seattle" });
            orders.Add(new Order() { OrderID = 10270, OrderDate = new DateTime(1996, 08, 01), CustomerName = "Pirkko Koskitalo", ShipCountry = "Finland", ShipCity = "Oulu" });
            orders.Add(new Order() { OrderID = 10271, OrderDate = new DateTime(1996, 08, 01), CustomerName = "Art Braunschweiger", ShipCountry = "USA", ShipCity = "Lander" });
            orders.Add(new Order() { OrderID = 10272, OrderDate = new DateTime(1996, 08, 02), CustomerName = "Paula Wilson", ShipCountry = "USA", ShipCity = "Albuquerque" });
            orders.Add(new Order() { OrderID = 10273, OrderDate = new DateTime(1996, 08, 05), CustomerName = "Horst Kloss", ShipCountry = "Germany", ShipCity = "Cunewalde" });
            orders.Add(new Order() { OrderID = 10274, OrderDate = new DateTime(1996, 08, 06), CustomerName = "Paul Henriot", ShipCountry = "France", ShipCity = "Reims" });
            orders.Add(new Order() { OrderID = 10275, OrderDate = new DateTime(1996, 08, 07), CustomerName = "Giovanni Rovelli", ShipCountry = "Italy", ShipCity = "Bergamo" });
            orders.Add(new Order() { OrderID = 10276, OrderDate = new DateTime(1996, 08, 08), CustomerName = "Miguel Angel Paolino", ShipCountry = "Mexico", ShipCity = "México D.F." });
            orders.Add(new Order() { OrderID = 10277, OrderDate = new DateTime(1996, 08, 09), CustomerName = "Alexander Feuer", ShipCountry = "Germany", ShipCity = "Leipzig" });
            orders.Add(new Order() { OrderID = 10278, OrderDate = new DateTime(1996, 08, 12), CustomerName = "Christina Berglund", ShipCountry = "Sweden", ShipCity = "Luleå" });
            orders.Add(new Order() { OrderID = 10279, OrderDate = new DateTime(1996, 08, 13), CustomerName = "Renate Messner", ShipCountry = "Germany", ShipCity = "Frankfurt a.M." });
            orders.Add(new Order() { OrderID = 10280, OrderDate = new DateTime(1996, 08, 14), CustomerName = "Christina Berglund", ShipCountry = "Sweden", ShipCity = "Luleå" });
            orders.Add(new Order() { OrderID = 10281, OrderDate = new DateTime(1996, 08, 14), CustomerName = "Alejandra Camino", ShipCountry = "Spain", ShipCity = "Madrid" });
            orders.Add(new Order() { OrderID = 10282, OrderDate = new DateTime(1996, 08, 15), CustomerName = "Alejandra Camino", ShipCountry = "Spain", ShipCity = "Madrid" });
            orders.Add(new Order() { OrderID = 10283, OrderDate = new DateTime(1996, 08, 16), CustomerName = "Carlos González", ShipCountry = "Venezuela", ShipCity = "Barquisimeto" });
            orders.Add(new Order() { OrderID = 10284, OrderDate = new DateTime(1996, 08, 19), CustomerName = "Renate Messner", ShipCountry = "Germany", ShipCity = "Frankfurt a.M." });
            orders.Add(new Order() { OrderID = 10285, OrderDate = new DateTime(1996, 08, 20), CustomerName = "Horst Kloss", ShipCountry = "Germany", ShipCity = "Cunewalde" });
            orders.Add(new Order() { OrderID = 10286, OrderDate = new DateTime(1996, 08, 21), CustomerName = "Horst Kloss", ShipCountry = "Germany", ShipCity = "Cunewalde" });
            orders.Add(new Order() { OrderID = 10287, OrderDate = new DateTime(1996, 08, 22), CustomerName = "Janete Limeira", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" });
            orders.Add(new Order() { OrderID = 10288, OrderDate = new DateTime(1996, 08, 23), CustomerName = "Maurizio Moroni", ShipCountry = "Italy", ShipCity = "Reggio Emilia" });
            orders.Add(new Order() { OrderID = 10289, OrderDate = new DateTime(1996, 08, 26), CustomerName = "Victoria Ashworth", ShipCountry = "UK", ShipCity = "London" });
            orders.Add(new Order() { OrderID = 10290, OrderDate = new DateTime(1996, 08, 27), CustomerName = "Pedro Afonso", ShipCountry = "Brazil", ShipCity = "Sao Paulo" });
            orders.Add(new Order() { OrderID = 10291, OrderDate = new DateTime(1996, 08, 27), CustomerName = "Bernardo Batista", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" });
            orders.Add(new Order() { OrderID = 10292, OrderDate = new DateTime(1996, 08, 28), CustomerName = "Anabela Domingues", ShipCountry = "Brazil", ShipCity = "Sao Paulo" });
            orders.Add(new Order() { OrderID = 10293, OrderDate = new DateTime(1996, 08, 29), CustomerName = "Miguel Angel Paolino", ShipCountry = "Mexico", ShipCity = "México D.F." });
            orders.Add(new Order() { OrderID = 10294, OrderDate = new DateTime(1996, 08, 30), CustomerName = "Paula Wilson", ShipCountry = "USA", ShipCity = "Albuquerque" });
            orders.Add(new Order() { OrderID = 10295, OrderDate = new DateTime(1996, 09, 02), CustomerName = "Paul Henriot", ShipCountry = "France", ShipCity = "Reims" });
            orders.Add(new Order() { OrderID = 10296, OrderDate = new DateTime(1996, 09, 03), CustomerName = "Carlos González", ShipCountry = "Venezuela", ShipCity = "Barquisimeto" });
            orders.Add(new Order() { OrderID = 10297, OrderDate = new DateTime(1996, 09, 04), CustomerName = "Frédérique Citeaux", ShipCountry = "France", ShipCity = "Strasbourg" });
            return orders;
        }

        public class Order
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public string CustomerName { get; set; }
            public string ShipCountry { get; set; }
            public string ShipCity { get; set; }
        }
    }
}

