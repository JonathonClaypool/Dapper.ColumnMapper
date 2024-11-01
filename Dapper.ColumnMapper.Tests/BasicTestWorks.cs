using Microsoft.Data.SqlClient;
using Xunit.Abstractions;

namespace Dapper.ColumnMapper.Tests;

public class BasicTestWorks(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public async Task TestBasicCaseWorksAsync()
    {
        DapperTypeMappingConfig.RegisterTypeMaps();
        // TODO: Move this test to creating a local database with fake data and testing against. 
        var connString = "<Hidden>";
        var conn = new SqlConnection(connString);
        await conn.OpenAsync();
        var query = "SELECT Name, Id FROM dbo.Person";

        var results = await conn.QueryAsync<Person>(query);

        var results2 = await conn.QueryAsync(query);
        
        Assert.NotNull(results);
        Assert.NotEmpty(results);
        
        foreach (var monsterCard in results)
        {
            testOutputHelper.WriteLine($"{monsterCard.TestId} {monsterCard.Description}");
        }

    }

    
    
}