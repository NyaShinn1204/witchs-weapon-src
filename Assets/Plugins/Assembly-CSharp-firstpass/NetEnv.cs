using System.Collections.Generic;
using System.Xml;

public class NetEnv
{
	public const int ERROR_TYPE_CONTENT_ERROR_ACCCONF = 3;

	public const int ERROR_TYPE_CONTENT_ERROR_ENV = 4;

	public const int ERROR_TYPE_CONTENT_ERROR_MAPPING = 5;

	protected const string domainConfig = "Config/xmlConf/accConf.xml";

	protected const string netPath = "/Config/xmlConf/net/";

	protected const string nameEnv = ".env";

	protected const string nameMapping = ".mapping";

	protected Domain domain;

	protected XmlDocument GetXMLDocByPath(string path)
	{
		return null;
	}

	protected XmlDocument GetXMLDocByContent(string xmlStr)
	{
		return null;
	}

	protected string GetConfigFileName(string channel)
	{
		return null;
	}

	protected string GetConfigFileURL(string channel)
	{
		return null;
	}

	private XmlNode FindNodeByID(string channel)
	{
		return null;
	}

	protected virtual List<Domain> ParseEnv(string content)
	{
		return null;
	}

	protected virtual Domain ParseMapping(string version, string content, List<Domain> domains)
	{
		return null;
	}

	public Domain GetDomain()
	{
		return null;
	}
}
