using System;

namespace DesignPatterns.Template_Method_Pattern
{
    public class UpsOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            
            Label = String.Format("UPS:[{0}]", ShippingAddress);
        }
    }
}
