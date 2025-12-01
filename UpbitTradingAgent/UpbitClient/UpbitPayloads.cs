using System.ComponentModel;

namespace UpbitTradingAgent.UpbitClient;

public class DayCandles
{
    public class Response
    {
        [Description("Market code")]
        public string market { get; set; }

        [Description("Candle reference time (UTC) - Format: yyyy-MM-dd'T'HH:mm:ss")]
        public DateTime candle_date_time_utc { get; set; }

        [Description("Candle reference time (KST) - Format: yyyy-MM-dd'T'HH:mm:ss")]
        public DateTime candle_date_time_kst { get; set; }

        [Description("Opening price")]
        public double opening_price { get; set; }

        [Description("Highest price")]
        public double high_price { get; set; }

        [Description("Lowest price")]
        public double low_price { get; set; }

        [Description("Closing price (trade price)")]
        public double trade_price { get; set; }

        [Description("Timestamp when the last tick was recorded")]
        public long timestamp { get; set; }

        [Description("Accumulated trade amount")]
        public double candle_acc_trade_price { get; set; }

        [Description("Accumulated trade volume")]
        public double candle_acc_trade_volume { get; set; }

        [Description("Previous day's closing price (based on UTC 0:00)")]
        public double prev_closing_price { get; set; }

        [Description("Price change compared to the previous day's closing price")]
        public double change_price { get; set; }

        [Description("Rate of change compared to the previous day's closing price")]
        public double change_rate { get; set; }
    }

    public class Request
    {
        [Description("Market code")]
        public string market { get; set; }
        [Description("End time (yyyy-MM-dd'T'HH:mm:ss)")]
        public string to { get; set; }
        [Description("Number of candles to retrieve")]
        public string count { get; set; }
        [Description("Currency to convert price to (e.g., KRW)")]
        public string convertingPriceUnit { get; set; }
    }   
}

public class Candles
{
    public class Request
    {
        [Description("Market code")]
        public string market { get; set; }
        [Description("End time (yyyy-MM-dd'T'HH:mm:ss)")]
        public string to { get; set; }
        [Description("Number of candles to retrieve")]
        public string count { get; set; }
    }
    public class Response
    {
        [Description("Market code")]
        public string market { get; set; }

        [Description("Candle reference time (UTC) - Format: yyyy-MM-dd'T'HH:mm:ss")]
        public DateTime candle_date_time_utc { get; set; }

        [Description("Candle reference time (KST) - Format: yyyy-MM-dd'T'HH:mm:ss")]
        public DateTime candle_date_time_kst { get; set; }

        [Description("Opening price")]
        public double opening_price { get; set; }

        [Description("Highest price")]
        public double high_price { get; set; }

        [Description("Lowest price")]
        public double low_price { get; set; }

        [Description("Closing price (trade price)")]
        public double trade_price { get; set; }

        [Description("Timestamp when the last tick was recorded")]
        public long timestamp { get; set; }

        [Description("Accumulated trade amount")]
        public double candle_acc_trade_price { get; set; }

        [Description("Accumulated trade volume")]
        public double candle_acc_trade_volume { get; set; }
        
        [Description("Candle unit (minutes)")]
        public int unit { get; set; }
    }

}

public class MarketCodes
{
    [Description("Market code")]
    public string market { get; set; }
    [Description("Korean name of the market")]
    public string korean_name { get; set; }
    [Description("English name of the market")]
    public string english_name { get; set; }
    [Description("Market warning")]
    public string market_warning { get; set; }
}

public class ApiKeys
{
    public class Response
    {
        [Description("Access key")]
        public string access_key { get; set; }
        [Description("Expiration time of the key")]
        public DateTime expire_at { get; set; }
    }
}

public class WalletStatus
{
    public class Response
    {
        [Description("Currency code")]
        public string currency { get; set; }
        [Description("Wallet status")]
        public string wallet_state { get; set; }
        [Description("Block status")]
        public string block_state { get; set; }
        [Description("Block height")]
        public int block_height { get; set; }
        [Description("Block update time")]
        public DateTime block_updated_at { get; set; }
    }
}
public class DepositKrw
{
    public class Request
    {
        [Description("Deposit amount")]
        public string amount { get; set; }
    }

    public class Response
    {
        [Description("Transaction type")]
        public string type { get; set; }
        [Description("Unique ID of the deposit")]
        public string uuid { get; set; }
        [Description("Currency")]
        public string currency { get; set; }
        [Description("Transaction ID")]
        public string txid { get; set; }
        [Description("Deposit status")]
        public string state { get; set; }
        [Description("Creation time")]
        public DateTime created_at { get; set; }
        [Description("Completion time")]
        public object done_at { get; set; }
        [Description("Deposit amount")]
        public string amount { get; set; }
        [Description("Fee")]
        public string fee { get; set; }
        [Description("Transaction type")]
        public string transaction_type { get; set; }
    }
}

public class CoinAddress
{
    public class Request
    {
        [Description("Currency code")]
        public string currency { get; set; }
    }
    public class Response
    {
        [Description("Currency code")]
        public string currency { get; set; }
        [Description("Deposit address")]
        public string deposit_address { get; set; }
        [Description("Secondary address (if any)")]
        public string secondary_address { get; set; }
    }
}
public class GenerateCoinAddress
{
    public class Response
    {
        [Description("Whether the address generation was successful")]
        public bool success { get; set; }
        [Description("Response message")]
        public string message { get; set; }
    }
    public class Request
    {
        [Description("Currency for which to generate an address")]
        public string currency { get; set; }
    }
}
public class Withdraw
{
    public class Response
    {
        [Description("Transaction type")]
        public string type { get; set; }
        [Description("Unique ID of the withdrawal")]
        public string uuid { get; set; }
        [Description("Currency")]
        public string currency { get; set; }
        [Description("Transaction ID")]
        public string txid { get; set; }
        [Description("Withdrawal status")]
        public string state { get; set; }
        [Description("Creation time")]
        public DateTime created_at { get; set; }
        [Description("Completion time")]
        public DateTime done_at { get; set; }
        [Description("Withdrawal amount")]
        public string amount { get; set; }
        [Description("Fee")]
        public string fee { get; set; }
        [Description("Transaction type")]
        public string transaction_type { get; set; }
    }
    public class Request
    {
        [Description("UUID of the withdrawal to query")]
        public string uuid { get; set; }
        [Description("Transaction ID of the withdrawal to query")]
        public string txid { get; set; }
        [Description("Currency of the withdrawal to query")]
        public string currency { get; set; }
    }
}

public class Withdraws
{
    public class Response
    {
        [Description("Transaction type")]
        public string type { get; set; }
        [Description("Unique ID of the withdrawal")]
        public string uuid { get; set; }
        [Description("Currency")]
        public string currency { get; set; }
        [Description("Transaction ID")]
        public string txid { get; set; }
        [Description("Withdrawal status")]
        public string state { get; set; }
        [Description("Creation time")]
        public DateTime created_at { get; set; }
        [Description("Completion time")]
        public DateTime done_at { get; set; }
        [Description("Withdrawal amount")]
        public string amount { get; set; }
        [Description("Fee")]
        public string fee { get; set; }
        [Description("Transaction type")]
        public string transaction_type { get; set; }
    }
    public class Request
    {
        [Description("Currency to query")]
        public string currency { get; set; }
        [Description("State to query")]
        public string state { get; set; }
        [Description("Number of results to return")]
        public string limit { get; set; }
        [Description("Page number")]
        public string page { get; set; }
        [Description("Sorting order")]
        public string order_by { get; set; }
    }
}
public class Order
{
    public class Response
    {
        public class Trade
        {
            [Description("Market ID")]
            public string market { get; set; }
            [Description("Unique ID of the trade")]
            public string uuid { get; set; }
            [Description("Trade price")]
            public string price { get; set; }
            [Description("Trade volume")]
            public string volume { get; set; }
            [Description("Total trade amount")]
            public string funds { get; set; }
            [Description("Order type (bid/ask)")]
            public string side { get; set; }
        }
        [Description("Unique ID of the order")]
        public string uuid { get; set; }
        [Description("Order type (bid/ask)")]
        public string side { get; set; }
        [Description("Order method")]
        public string ord_type { get; set; }
        [Description("Order price")]
        public string price { get; set; }
        [Description("Order state")]
        public string state { get; set; }
        [Description("Market ID")]
        public string market { get; set; }
        [Description("Order creation time")]
        public DateTime created_at { get; set; }
        [Description("Order volume")]
        public string volume { get; set; }
        [Description("Remaining volume")]
        public string remaining_volume { get; set; }
        [Description("Reserved fee")]
        public string reserved_fee { get; set; }
        [Description("Remaining fee")]
        public string remaining_fee { get; set; }
        [Description("Paid fee")]
        public string paid_fee { get; set; }
        [Description("Locked amount")]
        public string locked { get; set; }
        [Description("Executed volume")]
        public string executed_volume { get; set; }
        [Description("Number of trades")]
        public int trades_count { get; set; }
        [Description("List of trades")]
        public List<Trade> trades { get; set; }
    }
    public class Request
    {
        [Description("UUID of the order to query")]
        public string uuid { get; set; }
        [Description("Identifier of the order to query")]
        public string identifier { get; set; }
    }
}

public class ClosedOrderHistory
{
    public class Request 
    {
        [Description("Market to query")]
        public string market { get; set; }
        [Description("State to query")]
        public string state { get; set; }
        [Description("Number of results to return")]
        public string limit { get; set; }
        [Description("Sorting order")]
        public string order_by { get; set; }
    }
    
    public class Response
    {
        [Description("Unique ID of the order")]
        public string uuid { get; set; }
        
        [Description("Type of order (bid means `buy`/ask means `sell`)")]
        public string side { get; set; }
        
        [Description("Order method (e.g., limit, price, market)")]
        public string ord_type { get; set; }
        
        [Description("Currency price at the time of order")]
        public string price { get; set; }
        
        [Description("state of the order")]
        public string state { get; set; }
        
        [Description("Unique key of the market")]
        public string market { get; set; }
        
        [Description("Order creation time")]
        public DateTime created_at { get; set; }
        
        [Description("Order volume input by the user")]
        public string volume { get; set; }
        
        [Description("Remaining volume after execution")]
        public string executed_volume { get; set; }
        
        [Description("Executed volume")]
        public string executed_funds { get; set; }
        
        [Description("number of trades associated with the order")]
        public int trades_count { get; set; }
    }
}

public class Orders
{
    public class Request
    {
        [Description("Market to query")]
        public string market { get; set; }
        [Description("State to query")]
        public string state { get; set; }
        [Description("Page number")]
        public string page { get; set; }
        [Description("Number of results to return")]
        public string limit { get; set; }
        [Description("Sorting order")]
        public string order_by { get; set; }
    }
    public class Response
    {
        [Description("Unique ID of the order")]
        public string uuid { get; set; }
        [Description("Order type (bid/ask)")]
        public string side { get; set; }
        [Description("Order method")]
        public string ord_type { get; set; }
        [Description("Order price")]
        public string price { get; set; }
        [Description("Order state")]
        public string state { get; set; }
        [Description("Market ID")]
        public string market { get; set; }
        [Description("Order creation time")]
        public DateTime created_at { get; set; }
        [Description("Order volume")]
        public string volume { get; set; }
        [Description("Remaining volume")]
        public string remaining_volume { get; set; }
        [Description("Reserved fee")]
        public string reserved_fee { get; set; }
        [Description("Remaining fee")]
        public string remaining_fee { get; set; }
        [Description("Paid fee")]
        public string paid_fee { get; set; }
        [Description("Locked amount")]
        public string locked { get; set; }
        [Description("Executed volume")]
        public string executed_volume { get; set; }
        [Description("Number of trades")]
        public int trades_count { get; set; }
    }
}

public class CancelOrder
{
    public class Request
    {
        [Description("UUID of the order to cancel")]
        public string uuid { get; set; }
    }
    public class Response
    {
        [Description("Unique ID of the order")]
        public string uuid { get; set; }
        [Description("Order type (bid/ask)")]
        public string side { get; set; }
        [Description("Order method")]
        public string ord_type { get; set; }
        [Description("Order price")]
        public string price { get; set; }
        [Description("Order state")]
        public string state { get; set; }
        [Description("Market ID")]
        public string market { get; set; }
        [Description("Order creation time")]
        public DateTime created_at { get; set; }
        [Description("Order volume")]
        public string volume { get; set; }
        [Description("Remaining volume")]
        public string remaining_volume { get; set; }
        [Description("Reserved fee")]
        public string reserved_fee { get; set; }
        [Description("Remaining fee")]
        public string remaining_fee { get; set; }
        [Description("Paid fee")]
        public string paid_fee { get; set; }
        [Description("Locked amount")]
        public string locked { get; set; }
        [Description("Executed volume")]
        public string executed_volume { get; set; }
        [Description("Number of trades")]
        public int trades_count { get; set; }
    }
}

public class Ticks
{
    public class Response
    {
        [Description("Market code")]
        public string market { get; set; }
        [Description("Trade date (UTC)")]
        public string trade_date_utc { get; set; }
        [Description("Trade time (UTC)")]
        public string trade_time_utc { get; set; }
        [Description("Timestamp")]
        public long timestamp { get; set; }
        [Description("Trade price")]
        public int trade_price { get; set; }
        [Description("Trade volume")]
        public double trade_volume { get; set; }
        [Description("Previous closing price")]
        public int prev_closing_price { get; set; }
        [Description("Change in price")]
        public int chane_price { get; set; }
        [Description("Ask/bid classification")]
        public string ask_bid { get; set; }
    }
    public class Request
    {
        [Description("Market to query")]
        public string market { get; set; }
        [Description("Time to query until")]
        public string to { get; set; }
        [Description("Number of ticks to return")]
        public string count { get; set; }
        [Description("Cursor for pagination")]
        public string cursor { get; set; }
        [Description("Number of days ago")]
        public string daysAgo { get; set; }
    }
}
public class Ticker
{
    [Description("Market code")]
    public string market { get; set; }
    [Description("Trade date")]
    public string trade_date { get; set; }
    [Description("Trade time")]
    public string trade_time { get; set; }
    [Description("Trade date (KST)")]
    public string trade_date_kst { get; set; }
    [Description("Trade time (KST)")]
    public string trade_time_kst { get; set; }
    [Description("Trade timestamp")]
    public long trade_timestamp { get; set; }
    [Description("Opening price")]
    public double opening_price { get; set; }
    [Description("Highest price")]
    public double high_price { get; set; }
    [Description("Lowest price")]
    public double low_price { get; set; }
    [Description("Trade price")]
    public double trade_price { get; set; }
    [Description("Previous closing price")]
    public double prev_closing_price { get; set; }
    [Description("Change type (RISE/FALL/EVEN)")]
    public string change { get; set; }
    [Description("Change in price")]
    public double change_price { get; set; }
    [Description("Rate of change")]
    public double change_rate { get; set; }
    [Description("Signed change in price")]
    public double signed_change_price { get; set; }
    [Description("Signed rate of change")]
    public double signed_change_rate { get; set; }
    [Description("Trade volume")]
    public double trade_volume { get; set; }
    [Description("Accumulated trade price")]
    public double acc_trade_price { get; set; }
    [Description("Accumulated trade price (24h)")]
    public double acc_trade_price_24h { get; set; }
    [Description("Accumulated trade volume")]
    public double acc_trade_volume { get; set; }
    [Description("Accumulated trade volume (24h)")]
    public double acc_trade_volume_24h { get; set; }
    [Description("Highest price in 52 weeks")]
    public double highest_52_week_price { get; set; }
    [Description("Date of highest price in 52 weeks")]
    public string highest_52_week_date { get; set; }
    [Description("Lowest price in 52 weeks")]
    public double lowest_52_week_price { get; set; }
    [Description("Date of lowest price in 52 weeks")]
    public string lowest_52_week_date { get; set; }
    [Description("Timestamp")]
    public long timestamp { get; set; }
}

public class OrderBook
{
    public class Response
    {
        public class OrderbookUnit
        {
            [Description("Ask price")]
            public double ask_price { get; set; }
            [Description("Bid price")]
            public double bid_price { get; set; }
            [Description("Ask size")]
            public double ask_size { get; set; }
            [Description("Bid size")]
            public double bid_size { get; set; }
        }

        [Description("Market code")]
        public string market { get; set; }
        [Description("Timestamp")]
        public long timestamp { get; set; }
        [Description("Total ask size")]
        public double total_ask_size { get; set; }
        [Description("Total bid size")]
        public double total_bid_size { get; set; }
        [Description("List of order book units")]
        public List<OrderbookUnit> orderbook_units { get; set; }
    }
}
public class PlaceOrder
{
    public class Request
    {
        [Description("Market ID")]
        public string market { get; set; }
        [Description("Order type (bid/ask)")]
        public string side { get; set; }
        [Description("Order volume")]
        public string volume { get; set; }
        [Description("Order price")]
        public string price { get; set; }
        [Description("Order type (limit/market)")]
        public string ord_type { get; set; }
    }
    public class Response
    {
        [Description("Unique ID of the order")]
        public string uuid { get; set; }

        [Description("Type of order (bid means `buy`/ask means `sell`)")]
        public string side { get; set; }

        [Description("Order method (e.g., limit, price, market)")]
        public string ord_type { get; set; }

        [Description("Currency price at the time of order")]
        public string price { get; set; }

        [Description("Average price of executed trades")]
        public string avg_price { get; set; }

        [Description("Order status")]
        public string state { get; set; }

        [Description("Unique key of the market")]
        public string market { get; set; }

        [Description("Order creation time")]
        public DateTime created_at { get; set; }

        [Description("Order volume input by the user")]
        public string volume { get; set; }

        [Description("Remaining volume after execution")]
        public string remaining_volume { get; set; }

        [Description("Cost reserved for fees")]
        public string reserved_fee { get; set; }

        [Description("Remaining fee amount")]
        public string remaining_fee { get; set; }

        [Description("Fee amount that has been used")]
        public string paid_fee { get; set; }

        [Description("Cost currently locked for the trade")]
        public string locked { get; set; }

        [Description("Executed trade volume")]
        public string executed_volume { get; set; }

        [Description("Number of trades associated with the order")]
        public int trades_count { get; set; }

        public string GetPrompt()
        {
            var amount = string.IsNullOrEmpty(price) ? volume : price;
            
            return $"""
                    side is a string that indicates the type of order (bid means `buy`/ask means `sell`)
                    amount is a string that indicates the amount of order

                    market : {market}
                    side : {side}
                    amount : {amount}
                    """;
        }
    }
}

public class Chance
{
    
    public class Response
    {
        public class Bid
        {
            [Description("The uppercase English code representing the currency")]
            public string currency { get; set; }
            
            [Description("The unit of order amount")]
            public object price_unit { get; set; }
            
            [Description("You must spend at least this amount in a single order.")]
            public int min_total { get; set; }
        }

        public class Ask
        {
            [Description("The uppercase English code representing the currency")]
            public string currency { get; set; }
            
            [Description("The unit of order amount")]
            public object price_unit { get; set; }
            
            [Description("You must spend at least this amount in a single order.")]
            public int min_total { get; set; }
        }

        public class Market
        {
            [Description("The unique key of the market")]
            public string id { get; set; }
            
            [Description("The name of the market")]
            public string name { get; set; }
            
            public List<string> order_types { get; set; }
            
            public List<string> order_sides { get; set; }
            
            [Description("Restrictions when buying")]
            public Bid bid { get; set; }
            
            [Description("Restrictions when selling")]
            public Ask ask { get; set; }
            
            [Description("Maximum buy/sell amount")]
            public string max_total { get; set; }
            
            [Description("Market operating status")]
            public string state { get; set; }
        }

        public class BidAccount
        {
            [Description("The uppercase English code representing the currency")]
            public string currency { get; set; }
            
            [Description("Available amount/quantity for orders - You can place orders using this amount minus Locked and AskFee.")]
            public string balance { get; set; }
            
            [Description("Amount/quantity locked in ongoing orders")]
            public string locked { get; set; }
            
            [Description("Average purchase price")]
            public string avg_buy_price { get; set; }
            
            [Description("Whether the average purchase price has been modified")]
            public bool avg_buy_price_modified { get; set; }
            
            [Description("Currency used as the basis for average price")]
            public string unit_currency { get; set; }
        }

        public class AskAccount
        {
            [Description("The uppercase English code representing the currency")]
            public string currency { get; set; }
            
            [Description("Available amount/quantity for orders - You can place orders using this amount minus Locked and AskFee.")]
            public string balance { get; set; }
            
            [Description("Amount/quantity locked in ongoing orders")]
            public string locked { get; set; }
            
            [Description("Average purchase price")]
            public string avg_buy_price { get; set; }
            
            [Description("Whether the average purchase price has been modified")]
            public bool avg_buy_price_modified { get; set; }
            
            [Description("Currency used as the basis for average price")]
            public string unit_currency { get; set; }
        }

        [Description("Buy fee rate")]
        public string bid_fee { get; set; }
        
        [Description("Sell fee rate")]
        public string ask_fee { get; set; }
        
        [Description("Information about the market")]
        public Market market { get; set; }
        
        [Description("Account status for the currency used when buying")]
        public BidAccount bid_account { get; set; }
        
        [Description("Account status for the currency used when selling")]
        public AskAccount ask_account { get; set; }
    }
    
    public class Request
    {
        [Description("Market ID")]
        public string market { get; set; }
    }
}

public class Accounts
{
    public class Response
    {
        [Description("Currency code")]
        public string currency { get; set; }
        
        [Description("Available balance")]
        public string balance { get; set; }
        
        [Description("Locked balance")]
        public string locked { get; set; }
        
        [Description("Average buy price")]
        public string avg_buy_price { get; set; }
        
        [Description("Whether the average buy price was modified")]
        public bool avg_buy_price_modified { get; set; }
        
        [Description("Unit currency for average buy price")]
        public string unit_currency { get; set; }
    }
}