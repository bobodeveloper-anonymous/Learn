using System;

namespace Learn
{
    public class ApproveService
    {
        private readonly IStockService _stockService;
        

        public ApproveService(IStockService stockService)
        {
            _stockService = stockService;
        }


        public Request Approve(int requestId)
        {
            RequestService requestService = new RequestService();
            Request request = requestService.Get(1);
            request.Status = "Approve";
            _stockService.Remove(1);

            return request;
        }
    }
}