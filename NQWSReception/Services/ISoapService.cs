using ServiceReference;


namespace NQWSReception.Services
{
    public interface ISoapService
    {
        Task<List<CashierQueueInfo>> GetCashierQueueInfoAsync(int cashier, string host, int port);
        Task<List<Priority>> GetPriorityListAsync(string host, int port);
    }
}
