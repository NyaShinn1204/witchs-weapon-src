using System.Collections.Generic;
using CLRSharp;

public class ScriptEngine
{
	private static ScriptEngine _instance;

	public CLRSharp_Environment env;

	public ThreadContext context;

	private Dictionary<string, ScriptEngineContext> contextDic;

	private ScriptEngine()
	{
	}

	public static ScriptEngine GetInstance()
	{
		return null;
	}

	public ScriptEngineContext LoadContext(string fileName)
	{
		return null;
	}
}
