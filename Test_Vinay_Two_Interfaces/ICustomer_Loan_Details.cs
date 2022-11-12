using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vinay_Two_Interfaces
{
    public  interface ICustomer_Loan_Details
    {
        public string CustomerName { get; set; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }
        

        public abstract double PrincipleAmount();

    }
}
