using System;
using System.Collections.Generic;

namespace Learn
{
    public class StockService : IStockService
    {
        private Stock _Stock;
        public StockService(int onHand)
        {
            _Stock = new Stock(onHand);
        }

        public Stock Get()
        {
            return _Stock;
        }

        public void Receive(int quantity)
        {
            _Stock.Add(quantity);
        }

        public void Remove(int quantity)
        {
            _Stock.Remove(quantity);
        }
    }
}