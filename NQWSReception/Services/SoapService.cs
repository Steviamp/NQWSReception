using ServiceReference;

namespace NQWSReception.Services
{
    public class SoapService : ISoapService
    {
        private readonly NQWSReceptionSoapClient _client;

        public SoapService()
        {
            _client = new NQWSReceptionSoapClient(NQWSReceptionSoapClient.EndpointConfiguration.NQWSReceptionSoap);
        }

        public async Task<List<CashierQueueInfo>> GetCashierQueueInfoAsync(int cashier, string host, int port)
        {
            var response = await _client.GetCashierQueueInfoAsync(cashier, host, port);
            return response.Body?.GetCashierQueueInfoResult?.ToList() ?? new List<CashierQueueInfo>();
        }

        public async Task<List<Priority>> GetPriorityListAsync(string host, int port)
        {
            var response = await _client.GetPriorityListAsync(host, port);

            return response.Body?
                       .GetPriorityListResult?
                       .ToList()
                   ?? new List<Priority>();
        }
    }
}
