using Microsoft.Extensions.AI;
using OpenAI;

IChatClient client = new OpenAIClient(Environment.GetEnvironmentVariable("OPENAI_API_KEY"))
            .AsChatClient(modelId: "gpt-4o-mini");

var response = await client.CompleteAsync("Cuáles son las ciudades más grandes del mundo?");

System.Console.WriteLine(response.Message);