using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class GameSocket : MonoBehaviour
{
	private static GameSocket _instance;

	private Socket socket;

	private IPEndPoint endPoint;

	private static string serverIP;

	private static int port;

	public void Start()
	{
	}

	public static GameSocket GetInstance()
	{
		return null;
	}

	public void Connect()
	{
	}

	public void SendMessage(JSONData content)
	{
	}

	public new void SendMessage(string content)
	{
	}
}
