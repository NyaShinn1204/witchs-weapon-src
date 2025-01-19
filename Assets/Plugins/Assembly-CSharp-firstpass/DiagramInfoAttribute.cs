using System;

public class DiagramInfoAttribute : Attribute
{
	public string DiagramName { get; set; }

	public DiagramInfoAttribute(string diagramName)
	{
	}
}
