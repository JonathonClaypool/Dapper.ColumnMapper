namespace Dapper.ColumnMapper;

using System;
using System.Linq;
using System.Reflection;
using Dapper;

public class ColumnAttributeTypeMapper<T> : FallbackTypeMapper
{
    public ColumnAttributeTypeMapper()
        : base(new SqlMapper.ITypeMap[]
        {
            new CustomPropertyTypeMap(
                typeof(T),
                (type, columnName) =>
                {
                    // Get all properties, including non-public and inherited
                    var property = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                        .FirstOrDefault(prop =>
                        {
                            var attr = prop.GetCustomAttribute<ColumnNameAttribute>();
                            return attr != null && attr.Name.Equals(columnName, StringComparison.OrdinalIgnoreCase);
                        });
                    return property;
                }
            ),
            new DefaultTypeMap(typeof(T))
        })
    {
    }
}

