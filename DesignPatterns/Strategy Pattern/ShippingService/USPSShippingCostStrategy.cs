﻿namespace DesignPatterns.Strategy_Pattern.ShippingService
{
    public class USPSShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 3.00d;
        }
    }
}