using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Linq;

namespace GrpcServicedemo.Services
{
    public class EmployeeCRUDService : EmployeeCRUD.EmployeeCRUDBase
    {
        private readonly ILogger<EmployeeCRUDService> _logger;
        private dataAccess.AppDbContext db = null;
        public EmployeeCRUDService(ILogger<EmployeeCRUDService> logger, dataAccess.AppDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public override Task<Employees> SelectAll(Empty requestData, ServerCallContext context)
        {
            Employees responseData = new Employees();
            var query = from emp in db.Employees
                        select new Employee()
                        {
                            EmployeeID = emp.EmployeeId,
                            FirstName = emp.FirstName,
                            LastName = emp.LastName
                        };
            responseData.Items.AddRange(query.ToArray());
            return Task.FromResult(responseData);
        }
        //public override Task<HelloReply> SayHello(HelloRequest requestData, ServerCallContext context)
        //{
        //    return Task.FromResult(new HelloReply
        //    {
        //        Message = "hello" + requestData.Name
        //    });
        //}

        public override Task<Employee> SelectByID(EmployeeFilter requestData, ServerCallContext context)
        {
            var data = db.Employees.Find(requestData.EmployeeID);
            Employee emp = new Employee()
            {
                EmployeeID = data.EmployeeId,
                FirstName = data.FirstName,
                LastName = data.LastName
            };
            return Task.FromResult(emp);
        }

        public override Task<Empty> Insert(Employee requestData, ServerCallContext context)
        {
            db.Employees.Add(new dataAccess.Employee()
            {
                EmployeeId = requestData.EmployeeID,
                FirstName = requestData.FirstName,
                LastName = requestData.LastName
            });
            db.SaveChanges();
            return Task.FromResult(new Empty());
        }


        public override Task<Empty> Update(Employee requestData, ServerCallContext context)
        {
            db.Employees.Update(new dataAccess.Employee()
            {
                EmployeeId = requestData.EmployeeID,
                FirstName = requestData.FirstName,
                LastName = requestData.LastName
            });
            db.SaveChanges();
            return Task.FromResult(new Empty());
        }

        public override Task<Empty> Delete(EmployeeFilter requestData, ServerCallContext context)
        {
            var data = db.Employees.Find(requestData.EmployeeID);
            db.Employees.Remove(new dataAccess.Employee()
            {
                EmployeeId = data.EmployeeId,
                FirstName = data.FirstName,
                LastName = data.LastName
            });
            db.SaveChanges();
            return Task.FromResult(new Empty());
        }

    }
}
