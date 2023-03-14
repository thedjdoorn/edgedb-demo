using EdgeDB;
using EdgeDB.DataTypes;

namespace EdgeDB_Demo.Models;

[EdgeDBType]
public class Company
{
    // [EdgeDBDeserializer]
    // public Company(IDictionary<string, object> data)
    // {
    //     id = (Guid)data["id"]!;
    //     name = (string)data["name"]!;
    // }
    
    public Guid id { get; set; }
    public string name { get;set; }

    // [EdgeDBProperty("@employment_start")]
    public LocalDate employment_start { get; set; }
    //
    // [EdgeDBProperty("@employment_end")]
    public LocalDate employment_end { get; set; }

    public Person[] employees { get; set; }
    
}