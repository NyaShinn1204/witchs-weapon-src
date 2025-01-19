using System;

public class InjectAttribute : Attribute
{
	public string Name { get; set; }

	public InjectAttribute(string name)
	{
	}

	public InjectAttribute()
	{
	}
}
