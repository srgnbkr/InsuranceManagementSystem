using InsuranceManagementSystem.DataAccess.Abstract;
using InsuranceManagementSystem.Entities.Concrete;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.DataAccess.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        public IConfiguration Configuration { get; }
        public string connectionString;

        public CustomerRepository(IConfiguration configuration)
        {
            this.Configuration = configuration;
            connectionString = Configuration["ConnectionStrings:DefaultConnection"];

        }
        public Customer Add(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                SqlCommand command = new SqlCommand("SpInsertCustomer", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                
                command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                command.Parameters.AddWithValue("@LastName", customer.LastName);
                command.Parameters.AddWithValue("@IdentityNumber", customer.IdentityNumber);
                command.Parameters.AddWithValue("@BirthYear", customer.BirthYear);
                command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                command.Parameters.AddWithValue("@Email", customer.Email);



                command.ExecuteNonQuery();
                connection.Close();
                return customer;



            }
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
