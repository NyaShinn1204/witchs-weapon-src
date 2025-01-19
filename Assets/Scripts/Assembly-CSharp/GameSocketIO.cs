using BestHTTP.SocketIO;

public class GameSocketIO
{
	public const string MESSAGE_SEND = "message";

	public const string MESSAGE_CONTROL = "control";

	public const string SERVER = "10.0.0.171";

	public const int PORT = 8888;

	public const string SOCKET_IO_SERVE = "/socket.io/";

	public const string SPLIT_SYMBOL = "|";

	private SocketManager manager;

	public static GameSocketIO _instance;

	public void Start()
	{
	}

	public static GameSocketIO GetInstance()
	{
		return null;
	}

	public void SendMessage(string message)
	{
	}

	public void OnControl(Socket socket, Packet packet, params object[] args)
	{
	}

	private string GetIP()
	{
		return null;
	}
}
