string text = """
    .NET 9, the successor to .NET 8, has a special focus on cloud-native apps and performance.
     It will be supported for 18 months as a standard-term support (STS) release. 
     You can download .NET 9 here.

    New for .NET 9, the engineering team posts .NET 9 preview updates
    on GitHub Discussions. That's a great place to ask questions 
    and provide feedback about the release.
    """;

var words = text.Split([' ', '.', ','])
                .CountBy(word => word);

foreach (var item in words)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

IEnumerable<Movie> data =
    [
        new Movie(0, 42),
        new Movie(1, 5),
        new Movie(2, 4),
        new Movie(1, 10),
        new Movie(0, 25),
        new Movie(0, 3),
        new Movie(3, 54),
        new Movie(1, 12),
        new Movie(1, 2),
        new Movie(2, 33),
        new Movie(3, 1)
    ];

var aggregateData = data.AggregateBy(
    keySelector: movie => movie.Id,
    seed: 0,
    (totalScore, currentMovie) => totalScore + currentMovie.Score);

foreach (var item in aggregateData)
{
    System.Console.WriteLine(item);    
}
record Movie (int Id, int Score);