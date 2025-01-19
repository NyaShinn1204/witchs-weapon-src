using System;
using System.Collections.Generic;

public class MngrDataServer
{
	private static Dictionary<Type, MngrDataServer> _data;

	public static T GetData<T>() where T : MngrDataServer, new()
	{
		return null;
	}
}
