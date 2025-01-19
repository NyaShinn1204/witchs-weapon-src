public class LoggerModual : ILoggerModual
{
	public const string BLOCK_BEGIN = "[";

	public const string BLOCK_END = "]";

	public const string LINE_END = "\n";

	public const string _1 = "\n\t\t>>>";

	public const string _2 = "\n\t\t\t\t>>>";

	public const string _3 = "\n\t\t\t\t\t\t>>>";

	public const string _4 = "\n\t\t\t\t\t\t\t\t>>>";

	public const string _5 = "\n\t\t\t\t\t\t\t\t\t\t>>>";

	public const string _1t = "\t\t>>>";

	public const string _2t = "\t\t\t\t>>>";

	public const string _3t = "\t\t\t\t\t\t>>>";

	public const string _4t = "\t\t\t\t\t\t\t\t>>>";

	public const string _5t = "\t\t\t\t\t\t\t\t\t\t>>>";

	private string name;

	protected int outputType;

	public ITemplate fileTemplate;

	public ITemplate webTemplate;

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LoggerModual()
	{
	}

	public LoggerModual(string modualName)
	{
	}

	public virtual string RunFunction(int loglevel, string funcName, object self, params object[] obj)
	{
		return null;
	}

	protected string FormatPrefix(string funcName, object self, int logLevel = 1, bool useHash = true)
	{
		return null;
	}

	public ITemplate GetTemplate()
	{
		return null;
	}
}
