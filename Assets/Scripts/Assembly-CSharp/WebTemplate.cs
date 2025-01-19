public class WebTemplate : ITemplate
{
	public const int COLOR_INFO = 1;

	public const int COLOR_WARNNING = 2;

	public const int COLOR_ERROR = 3;

	public string Format(int type, string content, int indent = 0)
	{
		return null;
	}

	private string Info()
	{
		return null;
	}

	private string Warnning()
	{
		return null;
	}

	private string Error()
	{
		return null;
	}

	private string Time()
	{
		return null;
	}

	public string Color(string content, int color)
	{
		return null;
	}

	public string Bold(string content)
	{
		return null;
	}

	public string Italic(string content)
	{
		return null;
	}

	public string Indent(string content, int level)
	{
		return null;
	}

	public string LineEnd()
	{
		return null;
	}
}
