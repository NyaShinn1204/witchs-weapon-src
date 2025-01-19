using System.Collections.Generic;
using System.Xml;

public class NetMsgRouter
{
	private static NetMsgRouter _instance;

	public const int TYPE_NOTICE = 1;

	public const int TYPE_ACCOUNT = 2;

	public const int TYPE_GAME = 3;

	public const int TYPE_VERSION = 4;

	public const int TYPE_CDN = 5;

	public const string INTERFACE_ZONE = "ZONE_INTERFACE";

	public string accRemote;

	private XmlDocument doc;

	private bool isInit;

	public Domain domainConfObj;

	private Dictionary<int, string> dic_notice;

	private Dictionary<int, string> dic_acc;

	private Dictionary<int, string> dic_game;

	private NetMsgRouter()
	{
	}

	private NetMsgRouter(Domain domainObj)
	{
	}

	public static void Create(Domain domainObj)
	{
	}

	public static void ReCreate(Domain domainObj = null)
	{
	}

	public static NetMsgRouter Instance()
	{
		return null;
	}

	private void ReInit()
	{
	}

	private void SetDic(XmlDocument doc, string domain, int type)
	{
	}

	public string GetDomain(int type)
	{
		return null;
	}

	public string GetURL(int code)
	{
		return null;
	}

	public int GetType(int code)
	{
		return 0;
	}
}
