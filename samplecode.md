# Connect to DB
var settings = MongoClientSettings.FromConnectionString("mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");
settings.ServerApi = new ServerApi(ServerApiVersion.V1);
var client = new MongoClient(settings);

# Get DBs
var database = client.ListDatabases().ToList();
Console.WriteLine("The list of databases on this server is: ");
foreach (var db in database)
{
    Console.WriteLine(db);
}
    
# Save document to DB
var book = new BsonDocument
{
    { "isbn", "ISBN here" },
    { "book_name", "Book name here" },
    { "category", "Category _id here" },
    { "author", "Author _id here" },
    { "image", "Image link here" },
    { "availability", "Yes or no here" }
};
client.GetDatabase("LibrarySystem").GetCollection<BsonDocument>("Books").InsertOneAsync(book);