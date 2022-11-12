using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vinay_Two_Interfaces
{
    public class Calculate_Loan_Interest : ICustomer_Loan_Details, ILoan_Interest_Details
    {
        public string CustomerName { get ; set ; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }

        double CustomerLoanAmount;

         double RateOfInterest ;

        int time=3;

        public double FindInterestRate()
        {
            RateOfInterest = 2;
            return RateOfInterest;
        }

        public double PrincipleAmount()
        {
            CustomerLoanAmount = 2500;  
            return CustomerLoanAmount;

        }
        public void CalculateTotalAmount()
        {
            RateOfInterest = FindInterestRate();
            CustomerLoanAmount = PrincipleAmount();
            double interest = (CustomerLoanAmount * time * RateOfInterest) / 100;

            Console.WriteLine("Principle Amount : "+CustomerLoanAmount);  
            
            Console.WriteLine("Intrest for the Loan : "+interest);

            double totalAmount = CustomerLoanAmount + interest;
            Console.WriteLine("Total Amount Is : "+totalAmount);
        }
        public void SetAndDisplayCustomerDetails()
        {
            CustomerName = "vinay";
            MobileNumber = 9553358351;
            Address="Hyd";
            Console.WriteLine("Customer Name : "+CustomerName);
            Console.WriteLine(" Mobile Number  :"+MobileNumber);
            Console.WriteLine(" Address : "+Address);
        }
       
    }
}
