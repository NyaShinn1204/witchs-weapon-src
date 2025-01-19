using System;
using System.Collections;
using System.Runtime.InteropServices;

public class AotSafe
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	private delegate IEnumerator GetEnumerator();

	public static void ForEach<T>(object enumerable, Action<T> action)
	{
	}
}
