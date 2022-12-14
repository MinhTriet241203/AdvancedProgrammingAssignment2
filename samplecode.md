# Connect to DB
```csharp
var settings = MongoClientSettings.FromConnectionString("mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");
settings.ServerApi = new ServerApi(ServerApiVersion.V1);
var client = new MongoClient(settings);
```

### Get DBs
```csharp
//Get databases on server
var database = client.ListDatabases().ToList();
Console.WriteLine("The list of databases on this server is: ");
foreach (var db in database)
{
    Console.WriteLine(db);
}
```
[Reference](https://www.mongodb.com/blog/post/quick-start-c-sharp-and-mongodb-starting-and-setup)

# Add document to DB
```csharp
var book = new BsonDocument
{
    { "isbn", "ISBN here" },
    { "book_name", "Book name here" },
    { "category", "Category _id here" },
    { "author", "Author _id here" },
    { "image", "Image link here" },
    { "availability", "Yes or no here" }
};
//Get collection
var collection = client.GetDatabase("LibrarySystem").GetCollection<BsonDocument>("Books")
//Add to collection
collection.InsertOneAsync(book);
```
Mình có thể add thêm chức năng await nếu muốn nhưng mà function đó cần phải là function async
```csharp
await client.GetDatabase("LibrarySystem").GetCollection<BsonDocument>("Books").InsertOneAsync(book);
```
[Reference](https://www.mongodb.com/blog/post/quick-start-c-sharp-and-mongodb-creating-documents)
    
# Read documents from DB
```csharp
//Get collection
var collection = client.GetDatabase("LibrarySystem").GetCollection<BsonDocument>("Books");
//Read all documents in the DB
var allDocuments = collection.Find(new BsonDocument()).ToList();
foreach (var doc in allDocuments)
{
    Console.WriteLine(doc.ToString());
}
//Read with filter
var filter = Builders<BsonDocument>.Filter.Eq("isbn", "ISBN here");
var aDocument = collection.Find(filter).ToList();
foreach (var doc in aDocument)
{
    Console.WriteLine(doc.ToString());
}
```
[Reference](https://www.mongodb.com/blog/post/quick-start-c-and-mongodb-read-operations)