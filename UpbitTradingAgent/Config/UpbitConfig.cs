using System.ComponentModel.DataAnnotations;

namespace UpbitTradingAgent.Config;

public class UpbitConfig
{
    [Required]
    public string AccessKey { get; set; }
    
    [Required]
    public string SecretKey { get; set; }
}