namespace Dapper.ColumnMapper;

using System;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class ColumnNameAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}