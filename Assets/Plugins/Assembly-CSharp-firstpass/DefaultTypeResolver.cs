using System;

public class DefaultTypeResolver : ITypeResolver
{
	public Type GetType(string name)
	{
		return null;
	}

	public string SetType(Type type)
	{
		return null;
	}

	public virtual object CreateInstance(string name, string identifier)
	{
		return null;
	}
}
