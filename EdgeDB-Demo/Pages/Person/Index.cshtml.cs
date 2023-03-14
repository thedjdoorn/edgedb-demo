using EdgeDB;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EdgeDB_Demo.Pages.Person;

public class Index : PageModel
{
    public Index(EdgeDBClient client)
    {
        _client = client;
    }

    public Models.Person Person { get; set; }
    public string Id { get; private set; }
    private readonly EdgeDBClient _client;
    
    public async Task OnGet(string id)
    {
        Id = id;
        Person = await _client.QuerySingleAsync<Models.Person>(@"select Person {name, Companies:{id, name, address, @employment_start, @employment_end}, Interests:{id,name}} filter .id = <uuid>'"+Id+"'");
    }
}