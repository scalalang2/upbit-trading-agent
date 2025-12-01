namespace UpbitTradingAgent.UpbitClient;

/// <summary>
/// IUpbitClient is an interface for a client that interacts with Upbit Apis.
/// </summary>
public interface IUpbitClient
{
    /// <summary>
    /// Gets the history of closed orders.
    /// </summary>
    Task<List<ClosedOrderHistory.Response>> GetOrderHistory(ClosedOrderHistory.Request args);

    /// <summary>
    /// Gets a specific order by its UUID.
    /// </summary>
    Task<Order.Response> GetOrder(string uuid);

    /// <summary>
    /// Gets a list of open orders.
    /// </summary>
    Task<List<Orders.Response>> GetOrders(Orders.Request args);

    /// <summary>
    /// Gets the coin addresses for all coins.
    /// </summary>
    Task<List<CoinAddress.Response>> GetCoinAdresses();

    /// <summary>
    /// Gets the coin address for a specific coin.
    /// </summary>
    Task<CoinAddress.Response> GetCoinAdress(CoinAddress.Request args);

    /// <summary>
    /// Gets the order chance for a specific market.
    /// </summary>
    Task<Chance.Response> GetChance(Chance.Request args);

    /// <summary>
    /// Gets a specific withdrawal.
    /// </summary>
    Task<Withdraw.Response> GetWithdraw(Withdraw.Request args);

    /// <summary>
    /// Gets a list of withdrawals.
    /// </summary>
    Task<List<Withdraws.Response>> GetWithdraws(Withdraws.Request args);

    /// <summary>
    /// Cancels an order.
    /// </summary>
    Task<bool> CancelOrder(CancelOrder.Request args);

    /// <summary>
    /// Gets the wallet status.
    /// </summary>
    Task<List<WalletStatus.Response>> GetWalletStatus();

    /// <summary>
    /// Gets the API keys.
    /// </summary>
    Task<List<ApiKeys.Response>> GetApiKeys();

    /// <summary>
    /// Gets the account information.
    /// </summary>
    Task<List<Accounts.Response>> GetAccounts();

    /// <summary>
    /// Generates a new coin address.
    /// </summary>
    Task<GenerateCoinAddress.Response> GenerateCoinAddress(GenerateCoinAddress.Request args);

    /// <summary>
    /// Deposits KRW.
    /// </summary>
    Task<DepositKrw.Response> DepositKrw(DepositKrw.Request args);

    /// <summary>
    /// Places an order.
    /// </summary>
    Task<PlaceOrder.Response> PlaceOrder(PlaceOrder.Request args);

    /// <summary>
    /// Gets the recent ticks.
    /// </summary>
    Task<List<Ticks.Response>> GetTicks(Ticks.Request args);

    /// <summary>
    /// Gets the ticker for a specific symbol.
    /// </summary>
    Task<List<Ticker>> GetTicker(string symbol);

    /// <summary>
    /// Gets the market codes.
    /// </summary>
    Task<List<MarketCodes>> GetMarketCodes();

    /// <summary>
    /// Gets the daily candles.
    /// </summary>
    Task<List<DayCandles.Response>> GetDayCandles(DayCandles.Request args);

    /// <summary>
    /// Gets the weekly candles.
    /// </summary>
    Task<List<Candles.Response>> GetWeekCandles(Candles.Request args);

    /// <summary>
    /// Gets the monthly candles.
    /// </summary>
    Task<List<Candles.Response>> GetMonthCandles(Candles.Request args);

    /// <summary>
    /// Gets the minute candles.
    /// </summary>
    Task<List<Candles.Response>> GetMinuteCandles(int unit, Candles.Request args);

    /// <summary>
    /// Gets the order books.
    /// </summary>
    Task<List<OrderBook.Response>> GetOrderBooks(string symbol);
}