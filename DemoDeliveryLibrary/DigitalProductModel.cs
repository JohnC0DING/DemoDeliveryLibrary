using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDeliveryLibrary 
{
    public class DigitalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public int TotalDownloadsLeft { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if( HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing {Title} to { customer.EmailAddress }");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
