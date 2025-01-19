using System;
using System.Collections.Generic;
using CLRSharp;

public class ScriptEngineContext
{
	public CLRSharp_Environment env;

	public ThreadContext context;

	public void InitContext(string dllFileName, string pdbFileName)
	{
	}

	public void ExecuteStaticFunc(string className, string funcName)
	{
	}

	public object ExecuteNewFunc(string className)
	{
		return null;
	}

	public bool HasFunc(string className, string funcName)
	{
		return false;
	}

	public bool HasFunc(string className, string funcName, Dictionary<ICLRType, object> param)
	{
		return false;
	}

	public object ExecuteFunc(string className, object obj, string funcName)
	{
		return null;
	}

	public string ExecuteGetClassName(string path)
	{
		return null;
	}

	public object ExecuteFuncWithParams(string className, object obj, string funcName, Dictionary<ICLRType, object> param)
	{
		return null;
	}

	private IMethod GetMethod(string className, object obj, string funcName, Dictionary<ICLRType, object> param)
	{
		return null;
	}

	private MethodParamList GetParamList(Dictionary<ICLRType, object> param)
	{
		return null;
	}

	public Dictionary<ICLRType, object> AppendMathodParam(Type type, object obj)
	{
		return null;
	}
}
