using System;

public class UFRequireInstanceMethod : Attribute
{
	public string MethodName { get; set; }

	public UFRequireInstanceMethod(string canmovetochanged)
	{
	}
}
