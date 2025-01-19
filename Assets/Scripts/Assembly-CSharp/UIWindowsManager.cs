using System.Collections.Generic;
using System.Runtime.InteropServices;

public class UIWindowsManager
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void CloseAction();

	public enum GameState
	{
		GameStateNone = 0,
		GameStateLogin = 1,
		GameStateUI = 2,
		GameStateInBattle = 3
	}

	private Stack<CloseAction> closeActions;

	private GameState currentState;

	private static UIWindowsManager current;

	public static UIWindowsManager GetInstance()
	{
		return null;
	}

	public void AddCloseAction(CloseAction closeAction)
	{
	}

	public void RemoveAction()
	{
	}

	public void ClearActions()
	{
	}

	public void CloseAllAndGoBackMain()
	{
	}

	public void DoCloseAction()
	{
	}

	public void ChangeGameState(GameState gameState)
	{
	}
}
