

using System.ClientModel;
using Microsoft.Agents.AI;
using Microsoft.Agents.AI.DevUI;
using Microsoft.Agents.AI.Hosting;
using Microsoft.Agents.AI.Workflows;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenAI;

var builder = WebApplication.CreateBuilder(args);

// Set up the Azure OpenAI client
var endpoint = "http://localhost:11434/v1"; 
var deploymentName = "gemma3:1b"; 

var chatClient = new OpenAIClient(new ApiKeyCredential("dummy"), new OpenAIClientOptions
    {
        Endpoint = new Uri(endpoint),
    })
    .GetChatClient(deploymentName)
    .AsIChatClient();

builder.Services.AddChatClient(chatClient);

// Setup Agents
builder.AddAIAgent("poet", "You are a creative poet. Respond to all requests with beautiful poetry.");

builder.Services.AddOpenAIResponses();
builder.Services.AddOpenAIConversations();

var app = builder.Build();

app.MapOpenAIResponses();
app.MapOpenAIConversations();
app.MapDevUI();

Console.WriteLine("DevUI is available at: http://localhost:5000/devui");
Console.WriteLine("OpenAI Responses API is available at: http://localhost:5000/v1/responses");
Console.WriteLine("Press Ctrl+C to stop the server.");

app.Run();