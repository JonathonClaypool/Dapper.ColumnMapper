namespace Dapper.ColumnMapper.Tests;

public class MonsterCard
{
    [ColumnName("Name")]
    public string Description { get; set; } = "";

    [ColumnName("Hp")] public int TestId { get; set; } = 0;
}