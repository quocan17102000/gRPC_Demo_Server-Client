using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationClient.Models;

namespace WebApplicationClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new EmployeeCRUD.EmployeeCRUDClient(channel);

            var input = new HelloRequest { Name = "sss" };
            var v = await client.SayHelloAsync(input);
            Empty responsel = client.Insert(new Employee()
            {
                FirstName = "Tom",
                LastName = "Jerry"
            });
            Employee employee = client.SelectByID(new EmployeeFilter() { EmployeeID = 1 });
            employee.FirstName = "Tom123";
            employee.LastName = "Jerry123";
            Empty response2 = client.Update(employee);
            Employees employees = client.SelectAll(new Empty());
            return View(employees);
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
