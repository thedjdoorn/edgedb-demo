using EdgeDB;
using EdgeDB_Demo.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EdgeDB_Demo.Pages;

public class Companies : PageModel
{
    public Companies(EdgeDBClient client)
    {
        _client = client;
    }

    public Models.Company[] companies;
    public readonly EdgeDBClient _client;

    public async Task OnGet()
    {
        var result = await _client.QueryAsync<Models.Company>(@"select Company{id, name}");
        companies = result.ToArray(); 
    }
}