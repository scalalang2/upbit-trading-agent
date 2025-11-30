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
using UpbitTradingAgent.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Setup Agents
builder.ConfigureUpbitTradingAgentSystem();
builder.AddAIAgent("english teacher", "You're an English teacher. Help users improve their English skills.");

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