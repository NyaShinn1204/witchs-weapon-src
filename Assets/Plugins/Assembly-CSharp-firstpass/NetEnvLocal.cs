using System.Collections.Generic;

public class NetEnvLocal : NetEnv
{
	public void Init(string channel)
	{
	}

	public void InitByTool(string content)
	{
	}

	protected override Domain ParseMapping(string version, string content, List<Domain> domains)
	{
		return null;
	}
}
