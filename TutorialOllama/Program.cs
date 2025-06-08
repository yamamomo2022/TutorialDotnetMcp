using Microsoft.Extensions.AI;

IChatClient client =
    new OllamaChatClient(new Uri("http://192.168.0.8:11434/"), "qwen3");

Console.WriteLine(await client.GetResponseAsync(
    "なぜビックバンは起こったのか？"));