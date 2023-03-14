using EdgeDB;
using EdgeDB_Demo.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EdgeDB_Demo.Pages;

public class CompanyPageModel : PageModel
{
    public CompanyPageModel(EdgeDBClient client)
    {
        _client = client;
    }

    public string Id { get; set; }
    private readonly EdgeDBClient _client;
    public Models.Company Company { get; set; }
    public async Task OnGet(string id)
    {
        // var _client = new EdgeDBClient(EdgeDBConnection.FromInstanceName("famous_people"));
        Id=id;
        Company = await _client.QuerySingleAsync<Models.Company>(@"select Company{id, name, employees := .<Companies[is Person] {id, name, @employment_start, @employment_end}} filter .id=<uuid>'"+id+"'");
    }
}