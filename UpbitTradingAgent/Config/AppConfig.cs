using System.ComponentModel.DataAnnotations;

namespace UpbitTradingAgent.Config;

public class AppConfig
{
    /// <summary>
    /// Open AI API Endpoint
    /// </summary>
    public string OpenAIEndpoint { get; set; }
    
    /// <summary>
    /// Open AI API key for the application.
    /// </summary>
    [Required]
    public string OpenAIApiKey { get; set; }
    
    /// <summary>
    /// e.g. gpt-4.1
    /// </summary>
    [Required]
    public string SmartAIModel { get; set; }
    
    /// <summary>
    /// e.g. gpt-4.1-mini
    /// </summary>
    [Required]
    public string FastAIModel { get; set; }
    
    [Required]
    public UpbitConfig Upbit { get; set; }
}