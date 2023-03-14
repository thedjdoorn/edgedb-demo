using EdgeDB;
using EdgeDB_Demo.Pages;
using EdgeDB.DataTypes;

namespace EdgeDB_Demo.Models;

[EdgeDBType]
public class Person
{
    [EdgeDBDeserializer]
    public Person(IDictionary<string, object?> data)
    {
        id = (Guid)data["id"]!;
        name = (string)data["name"]!;
        foreach (var c in data["Companies"] as System.Object[])
        {
            Console.WriteLine(c is Company);
        }
        Companies = ((System.Object[])data["Companies"]).OfType<Company>().ToArray();
        Interests = ((System.Object[])data["Interests"]).OfType<Interest>().ToArray();
        // Companies = ((IDictionary<string, object>[])data["Companies"]).Select(it =>  new Company(it)).ToArray();
        // Interests = ((IDictionary<string, object>[])data["Interests"]).Select(it =>  new Interest(it)).ToArray();
    }
    public Guid id { get; set; }
    public string name { get; set; }

    public LocalDate employment_start { get; set; }
    public LocalDate? employment_end { get; set; }
    
    [EdgeDBProperty("Companies")]
    public Company[] Companies { get; set; }
    
    [EdgeDBProperty("Interests")]
    public Interest[] Interests { get; set; }
}