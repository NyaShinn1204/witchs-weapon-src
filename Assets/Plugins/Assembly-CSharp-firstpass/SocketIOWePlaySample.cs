using System.Collections.Generic;
using BestHTTP.SocketIO;
using UnityEngine;

public sealed class SocketIOWePlaySample : MonoBehaviour
{
	private enum States
	{
		Connecting = 0,
		WaitForNick = 1,
		Joined = 2
	}

	private string[] controls;

	private const float ratio = 1.5f;

	private int MaxMessages;

	private States State;

	private Socket Socket;

	private string Nick;

	private string messageToSend;

	private int connections;

	private List<string> messages;

	private Vector2 scrollPos;

	private Texture2D FrameTexture;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private void DrawLoginScreen()
	{
	}

	private void DrawControls()
	{
	}

	private void DrawChat(bool withInput = true)
	{
	}

	private void AddMessage(string msg)
	{
	}

	private void SendMessage()
	{
	}

	private void Join()
	{
	}

	private void Reload()
	{
	}

	private void OnConnected(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnJoined(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnReload(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnMessage(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnMove(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnJoin(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnConnections(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnFrame(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnError(Socket socket, Packet packet, params object[] args)
	{
	}
}
