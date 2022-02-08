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
    public class PaymentRepository : IPaymentRepository
    {
        public IConfiguration Configuration { get; }
        public string connectionString;

        public PaymentRepository(IConfiguration configuration)
        {
            this.Configuration = configuration;
            connectionString = Configuration["ConnectionStrings:DefaultConnection"];

        }


        public Payment Add(Payment payment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                SqlCommand command = new SqlCommand("SpInsertPayment", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                command.Parameters.AddWithValue("@PaymentPrice", payment.PaymentPrice);
                command.Parameters.AddWithValue("@CreditCardNumber", payment.CreditCardNumber);
                command.Parameters.AddWithValue("InsuredId", payment.InsuredId);
                command.Parameters.AddWithValue("@PaymentTypeId", payment.PaymentTypeId);
                command.ExecuteNonQuery();
                connection.Close();
                return payment;










            }
        }
    }
}
