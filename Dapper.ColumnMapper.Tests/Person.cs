namespace Dapper.ColumnMapper.Tests;

public class Person
{
    [ColumnName("Name")]
    public string Description { get; set; } = "";
    [ColumnName("Id")] 
    public int TestId { get; set; } = 0;
}