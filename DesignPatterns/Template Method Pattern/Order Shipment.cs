﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Method_Pattern
{
    public abstract class OrderShipment
    {
        public string ShippingAddress { get; set; }
        public string Label { get; set; }
        public void Ship(TextWriter writer)
        {
            VerifyShippingData();
            GetShippingLabelFromCarrier();
            PrintLabel(writer);
        }

        public virtual void VerifyShippingData()
        {
            if (String.IsNullOrEmpty(ShippingAddress))
            {
                throw new ApplicationException("Invalid address.");
            }
        }
        public abstract void GetShippingLabelFromCarrier();
        public virtual void PrintLabel(TextWriter writer)
        {
            writer.Write(Label);
        }
    }
}
