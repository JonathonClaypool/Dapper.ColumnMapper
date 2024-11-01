namespace Dapper.ColumnMapper;

using System;
using System.Reflection;
using Dapper;

public class FallbackTypeMapper(SqlMapper.ITypeMap[] mappers) : SqlMapper.ITypeMap
{
    public ConstructorInfo FindConstructor(string[] names, Type[] types)
    {
        foreach (var mapper in mappers)
        {
            var result = mapper.FindConstructor(names, types);
            if (result != null)
            {
                return result;
            }
        }
        return null;
    }

    public ConstructorInfo FindExplicitConstructor()
    {
        foreach (var mapper in mappers)
        {
            var result = mapper.FindExplicitConstructor();
            if (result != null)
            {
                return result;
            }
        }
        return null;
    }

    public SqlMapper.IMemberMap GetConstructorParameter(ConstructorInfo constructor, string columnName)
    {
        foreach (var mapper in mappers)
        {
            var result = mapper.GetConstructorParameter(constructor, columnName);
            if (result != null)
            {
                return result;
            }
        }
        return null;
    }

    public SqlMapper.IMemberMap GetMember(string columnName)
    {
        foreach (var mapper in mappers)
        {
            var result = mapper.GetMember(columnName);
            if (result != null)
            {
                return result;
            }
        }
        return null;
    }
}
