namespace UpbitTradingAgent.Config;

public class AppConfig
{
    public string OpenAIEndpoint { get; set; }
    
    /// <summary>
    /// Open AI API key for the application.
    /// </summary>
    public string OpenAIApiKey { get; set; } = string.Empty;
    
    /// <summary>
    /// e.g. gpt-4.1
    /// </summary>
    public string SmartAIModel { get; set; }
    
    /// <summary>
    /// e.g. gpt-4.1-mini
    /// </summary>
    public string FastAIModel { get; set; }
    
    public UpbitConfig Upbit { get; set; }
}