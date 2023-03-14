using EdgeDB;

namespace EdgeDB_Demo.Models;

[EdgeDBType]
public class Interest
{
    [EdgeDBDeserializer]
    public Interest(IDictionary<string, object> data)
    {
        id = (Guid)data["id"]!;
        name = (string)data["name"]!;
    }

    public Guid id { get; set; }
    public string name { get; set; }
}