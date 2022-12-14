# Connect to DB
```csharp
var settings = MongoClientSettings.FromConnectionString("mongodb+srv://admin:HWiRjWnroiKmcyQw@librarymanagement.io7gmky.mongodb.net/?retryWrites=true&w=majority");
settings.ServerApi = new ServerApi(ServerApiVersion.V1);
var client = new MongoClient(settings);
```

## Get DBs
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

# Update document in DB
```csharp
//Get collection
var collection = client.GetDatabase("LibrarySystem").GetCollection<BsonDocument>("Books");
//Filter to choose what document to update
var filter = Builders<BsonDocument>.Filter.Eq("isbn", "ISBN here");
//Set new values
var update = Builders<BsonDocument>.Update.Set("isbn", "Insert ISBN here")
    .Set("book_name", "Book name here").Set("category", "Category _id").Set("author", "Author _id here")
    .Set("image", "Image link here").Set("availability", "Availability here");

collection.UpdateOne(filter, update);
```
[Reference](https://www.mongodb.com/blog/post/quick-start-csharp-and-mongodb-update-operation)

# Delete document in DB
```csharp
//Get collection
var collection = client.GetDatabase("LibrarySystem").GetCollection<BsonDocument>("Books");
//Filter to delete
var filter = Builders<BsonDocument>.Filter.Eq("isbn", "Insert ISBN here");
collection.DeleteOne(filter);
```
[Reference](https://www.mongodb.com/blog/post/quick-start-csharp-and-mongodb-delete-operations)

# More advanced filter
```csharp
var filter = Builders<BsonDocument>.Filter.ElemMatch<BsonValue>("scores", new BsonDocument { 
    { "type", "exam" }, {"score", new BsonDocument { { "$lt", 60 }}}
});
```