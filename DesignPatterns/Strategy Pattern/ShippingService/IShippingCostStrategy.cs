
namespace DesignPatterns.Strategy_Pattern.ShippingService
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}