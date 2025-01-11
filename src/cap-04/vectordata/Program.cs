using Microsoft.Extensions.AI;
using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel.Connectors.InMemory;
using OpenAI.Embeddings;

var vectoreStore = new InMemoryVectorStore();

var movies = vectoreStore.GetCollection<int, Movie>("movies");

await movies.CreateCollectionIfNotExistsAsync();

var embeddingClient = new EmbeddingClient("text-embedding-3-large",
                             Environment.GetEnvironmentVariable("OPENAI_API_KEY"));

var embeddingGenerator = new OpenAIEmbeddingGenerator(embeddingClient);

var movieData = Movies.Data;

foreach (var movie in movieData)
{
    movie.Vector = await embeddingGenerator.GenerateEmbeddingVectorAsync(movie.Overview);
    await movies.UpsertAsync(movie);
}

while (true)
{
    var query = Console.ReadLine();

    var queryEmbedding = await embeddingGenerator!.GenerateEmbeddingVectorAsync(query);

    var searchOptions = new VectorSearchOptions()
    {
        Top = 1,
        VectorPropertyName = "Vector"
    };

    var results = await movies.VectorizedSearchAsync(queryEmbedding, searchOptions);

    await foreach (var result in results.Results)
    {
        System.Console.WriteLine($"Title: {result.Record.Title}");
        System.Console.WriteLine($"Overview: {result.Record.Overview}");
        System.Console.WriteLine($"Score: {result.Score}");
        System.Console.WriteLine();
    }
}