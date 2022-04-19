using System;
using System.Collections.Generic;
using System.Text;

namespace CarsDotNetCore.Entity
{
    class CustomerDetails
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string EmailId { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public int MobileNumber { get; set; }
    }
}
