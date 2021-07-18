using System;

namespace Learn
{
    public class Request
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Request r = (Request)obj;
                return this.Id == r.Id && this.Status == r.Status;
            }
        }
    }
}