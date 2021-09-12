using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDeliveryLibrary
{
    public interface IProductModel
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; }
        void ShipItem(CustomerModel customer);
    }
}
