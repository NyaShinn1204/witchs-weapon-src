using System;
using BestHTTP.Examples;
using BestHTTP.SignalR;
using UnityEngine;

public sealed class ConnectionAPISample : MonoBehaviour
{
	private enum MessageTypes
	{
		Send = 0,
		Broadcast = 1,
		Join = 2,
		PrivateMessage = 3,
		AddToGroup = 4,
		RemoveFromGroup = 5,
		SendToGroup = 6,
		BroadcastExceptMe = 7
	}

	private readonly Uri URI;

	private Connection signalRConnection;

	private string ToEveryBodyText;

	private string ToMeText;

	private string PrivateMessageText;

	private string PrivateMessageUserOrGroupName;

	private GUIMessageList messages;

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void OnDestroy()
	{
	}

	private void signalRConnection_OnGeneralMessage(Connection manager, object data)
	{
	}

	private void signalRConnection_OnStateChanged(Connection manager, ConnectionStates oldState, ConnectionStates newState)
	{
	}

	private void Broadcast(string text)
	{
	}

	private void BroadcastExceptMe(string text)
	{
	}

	private void EnterName(string name)
	{
	}

	private void JoinGroup(string groupName)
	{
	}

	private void LeaveGroup(string groupName)
	{
	}

	private void SendToMe(string text)
	{
	}

	private void SendToUser(string userOrGroupName, string text)
	{
	}

	private void SendToGroup(string userOrGroupName, string text)
	{
	}
}
