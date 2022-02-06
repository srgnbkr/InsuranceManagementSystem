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
    public class PolicyRepository : IPolicyRepository
    {
        public IConfiguration Configuration { get; }
        public string connectionString;

        public PolicyRepository(IConfiguration configuration)
        {
            this.Configuration = configuration;
            connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            
        }

        public List<Policy> GetAll()
        {
            List<Policy> policies = new List<Policy>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                
                    SqlCommand command = new SqlCommand("[dbo].[sp_GetAll_Policy]", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Policy policy = new Policy();
                        policy.PolicyId = Convert.ToInt32(reader["PolicyId"]);
                        policy.Name = reader["Name"].ToString();
                        policy.Description = reader["Description"].ToString();
                        policy.Price = Convert.ToDecimal(reader["Price"]);
                        policies.Add(policy);
                    }
                    reader.Close();
                
                
            }
            return policies;
        }

        public Policy Add(Policy policy)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                SqlCommand command = new SqlCommand("[dbo].[sp_Policy_Insert]", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                //command.Parameters.AddWithValue("@PolicyId", policy.PolicyId); //IsIdentity
                command.Parameters.AddWithValue("@Name", policy.Name);
                command.Parameters.AddWithValue("@Description", policy.Description);
                command.Parameters.AddWithValue("@Price", policy.Price);

                command.ExecuteNonQuery();
                connection.Close();
                return policy;
               


            }
            
        }
    }
}
