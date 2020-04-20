namespace DesignPatterns.Strategy_Pattern.ShippingService
{
    public class UPSShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 4.25d;
        }
    }
}