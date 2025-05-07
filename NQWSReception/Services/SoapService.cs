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
            var request = new GetCashierQueueInfo
            {
                Cashier = cashier,
                Host = host,
                Port = port
            };

            var response = await _client.GetCashierQueueInfoAsync(request);
            return response.GetCashierQueueInfoResult.ToList();
        }
    }
}
