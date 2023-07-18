using DesignPatternsLabb3;

public interface IWarmDrinkFactory
{
    IWarmDrink Prepare(int total);
}