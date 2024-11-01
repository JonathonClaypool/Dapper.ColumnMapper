namespace Dapper.ColumnMapper;

using System;
using System.Linq;
using System.Reflection;
using Dapper;

public static class DapperTypeMappingConfig
{
    public static void RegisterTypeMaps()
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        var typesWithAttribute = assemblies.SelectMany(assembly => assembly.GetTypes()).Where(t => t
            .GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |
                           BindingFlags.FlattenHierarchy)
            .Any(p => p.GetCustomAttribute<ColumnNameAttribute>() != null));
        foreach (var type in typesWithAttribute)
        {
            Console.WriteLine($"Registering type map for type: {type.FullName}");
            var mapperType = typeof(ColumnAttributeTypeMapper<>).MakeGenericType(type);
            var mapperInstance = Activator.CreateInstance(mapperType) as SqlMapper.ITypeMap;
            SqlMapper.SetTypeMap(type, mapperInstance);
        }
    }
}
