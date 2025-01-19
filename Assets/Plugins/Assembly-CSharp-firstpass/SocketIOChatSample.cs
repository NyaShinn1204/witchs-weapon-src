using System;
using System.Collections.Generic;
using BestHTTP.SocketIO;
using UnityEngine;

public sealed class SocketIOChatSample : MonoBehaviour
{
	private enum ChatStates
	{
		Login = 0,
		Chat = 1
	}

	private readonly TimeSpan TYPING_TIMER_LENGTH;

	private SocketManager Manager;

	private ChatStates State;

	private string userName;

	private string message;

	private string chatLog;

	private Vector2 scrollPos;

	private bool typing;

	private DateTime lastTypingTime;

	private List<string> typingUsers;

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

	private void DrawChatScreen()
	{
	}

	private void SetUserName()
	{
	}

	private void SendMessage()
	{
	}

	private void UpdateTyping()
	{
	}

	private void addParticipantsMessage(Dictionary<string, object> data)
	{
	}

	private void addChatMessage(Dictionary<string, object> data)
	{
	}

	private void AddChatTyping(Dictionary<string, object> data)
	{
	}

	private void RemoveChatTyping(Dictionary<string, object> data)
	{
	}

	private void OnLogin(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnNewMessage(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnUserJoined(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnUserLeft(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnTyping(Socket socket, Packet packet, params object[] args)
	{
	}

	private void OnStopTyping(Socket socket, Packet packet, params object[] args)
	{
	}
}
