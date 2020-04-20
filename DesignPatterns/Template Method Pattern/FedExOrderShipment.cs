using System;

namespace DesignPatterns.Template_Method_Pattern
{
    public class FedExOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            
            Label = String.Format("FedEx:[{0}]", ShippingAddress);
        }
    }
}
