using System;

namespace Learn
{
    public class RequestService
    {
        public RequestService()
        {
        }

        public Request Get(int requestId)
        {
            return new Request { Id = 1, Status = "Request" };
        }
    }
}