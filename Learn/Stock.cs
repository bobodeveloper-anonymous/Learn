using System;

namespace Learn
{
    public class Stock
    {
        private int _OnHand;

        public Stock(int onHand)
        {
            _OnHand = onHand;
        }

        public int OnHand => _OnHand;

        public void Add(int quantity)
        {
            _OnHand += quantity;
        }

        public void Remove(int quantity)
        {
            _OnHand -= quantity;
        }

        public static Stock operator +(Stock a, Stock b) => new Stock(a.OnHand + b.OnHand);

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Stock p = (Stock)obj;
                return this._OnHand == p.OnHand;
            }
        }
    }
}