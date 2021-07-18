namespace Learn
{
    public interface IStockService
    {
        Stock Get();
        void Receive(int quantity);
        void Remove(int quantity);
    }
}