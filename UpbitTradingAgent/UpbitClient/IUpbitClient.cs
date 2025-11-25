namespace UpbitTradingAgent.UpbitClient;


/// <summary>
/// ITraderClient is an interface for a client that interacts with a trading platform.
/// (e.g. Upbit, Binance, etc..)
/// </summary>
public interface IUpbitClient
{
    public Task<Chance.Response> GetChance(Chance.Request args);
    
    public Task<PlaceOrder.Response> PlaceOrder(PlaceOrder.Request args);
    
    public Task<List<Ticker>> GetTicker(string symbol);
    
    public Task<List<DayCandles.Response>> GetDayCandles(DayCandles.Request args);
    
    public Task<List<Candles.Response>> GetMinuteCandles(int unit, Candles.Request args);

    public Task<List<ClosedOrderHistory.Response>> GetOrderHistory(ClosedOrderHistory.Request args);

    public Task<Order.Response> GetOrder(string uuid);
}