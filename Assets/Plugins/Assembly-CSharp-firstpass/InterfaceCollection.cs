using System.Collections.Generic;

public class InterfaceCollection
{
	private static InterfaceCollection _instance;

	private Dictionary<string, IInterface> dic;

	private InterfaceCollection()
	{
	}

	public static InterfaceCollection Instance()
	{
		return null;
	}

	public void AddInterface(string name, IInterface inter)
	{
	}

	public IInterface GetInterface(string name)
	{
		return null;
	}
}
