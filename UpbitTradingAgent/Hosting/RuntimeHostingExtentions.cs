using System.ClientModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenAI;
using UpbitTradingAgent.Config;

namespace UpbitTradingAgent.Hosting;

public static class RuntimeHostingExtentions
{
    public static WebApplicationBuilder ConfigureUpbitTradingAgentSystem(this WebApplicationBuilder hostBuilder)
    {
        var configuration = hostBuilder.Configuration;
        var services = hostBuilder.Services;
    
        var appConfig = configuration.GetSection("Application").Get<AppConfig>() ?? new AppConfig();
        services.AddOptions<AppConfig>()
            .Bind(configuration.GetSection("Application"))
            .ValidateDataAnnotations()
            .ValidateOnStart();
        
        // Set up the Azure OpenAI client
        if (!string.IsNullOrEmpty(appConfig.OpenAIEndpoint))
        {
            var chatClient = new OpenAIClient(new ApiKeyCredential(appConfig.OpenAIApiKey), new OpenAIClientOptions
                {
                    Endpoint = new Uri(appConfig.OpenAIEndpoint),
                })
                .GetChatClient(appConfig.SmartAIModel)
                .AsIChatClient();
            
            services.AddChatClient(chatClient);
        }
        else
        {
            var chatClient = new OpenAIClient(new ApiKeyCredential(appConfig.OpenAIApiKey))
                .GetChatClient(appConfig.SmartAIModel)
                .AsIChatClient();
            services.AddChatClient(chatClient);
        }
        
        return hostBuilder;
    }
}