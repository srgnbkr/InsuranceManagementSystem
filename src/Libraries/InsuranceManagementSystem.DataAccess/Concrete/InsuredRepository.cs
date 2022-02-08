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
    public class InsuredRepository : IInsuredRepository
    {
        public IConfiguration Configuration { get; }
        public string connectionString;

        public InsuredRepository(IConfiguration configuration)
        {
            this.Configuration = configuration;
            connectionString = Configuration["ConnectionStrings:DefaultConnection"];

        }
        public Insured Add(Insured insured)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                SqlCommand command = new SqlCommand("SpInsertInsureds", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                command.Parameters.AddWithValue("@FirstName", insured.FirstName);
                command.Parameters.AddWithValue("@LastName", insured.LastName);
                command.Parameters.AddWithValue("@IdentityNumber", insured.IdentityNumber);
                command.Parameters.AddWithValue("@BirthYear", insured.BirthYear);
                command.Parameters.AddWithValue("@Gender", insured.Gender);
                command.Parameters.AddWithValue("@Degree", insured.Degree);
                command.Parameters.AddWithValue("@CustomerId", insured.CustomerId);
                command.Parameters.AddWithValue("@PolicyId", insured.PolicyId);
                command.Parameters.AddWithValue("@Status", insured.Status);





                command.ExecuteNonQuery();
                connection.Close();
                return insured;



            }
        }
    }
}
