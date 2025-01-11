using Microsoft.Extensions.VectorData;

public static class Movies 
{
    public static List<Movie> Data =
    [
        new() {
                Id=1,
                Title="The Shawshank Redemption", 
                Overview="Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
            },
        new() {
                Id=2,
                Title="The Godfather", 
                Overview="An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son."
            },
        new() {
                Id=3,
                Title="The Dark Knight", 
                Overview="When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
            },
        new() {
                Id=4,
                Title="The Godfather: Part II", 
                Overview="The early life and career of Vito Corleone in 1920s New York City is portrayed while his son, Michael, expands and tightens his grip on the family crime syndicate."
            },
        new() {
                Id=5,
                Title="12 Angry Men", 
                Overview="A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence."
            },
        new() {
                Id=6,
                Title="Schindler's List", 
                Overview="In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis."
            }
    ];
}


public class Movie
{
    [VectorStoreRecordKey]
    public int Id {get;set;}

    [VectorStoreRecordData] 
    public string Title {get;set;}

    [VectorStoreRecordData]
    public string Overview {get;set;}

    [VectorStoreRecordVector(384, DistanceFunction.CosineSimilarity)]
    public ReadOnlyMemory<float> Vector {get;set;}
}