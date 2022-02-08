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
    public class PaymentTypeRepository : IPaymentTypeRepository
    {
        public IConfiguration Configuration { get; }
        public string connectionString;

        public PaymentTypeRepository(IConfiguration configuration)
        {
            this.Configuration = configuration;
            connectionString = Configuration["ConnectionStrings:DefaultConnection"];

        }

        public List<PaymentType> GetAll()
        {
            List<PaymentType> paymentTypes = new List<PaymentType>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                SqlCommand command = new SqlCommand("SpPaymentTypeGetAll", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PaymentType paymentType = new PaymentType();
                    paymentType.PaymentTypeId = Convert.ToInt32(reader["PaymentTypeId"]);
                    paymentType.Description = reader["Description"].ToString();
                    paymentType.Amount = Convert.ToInt32(reader["Amount"]);
                    
                    paymentTypes.Add(paymentType);
                }
                reader.Close();


            }
            return paymentTypes;
        }
    }
}
