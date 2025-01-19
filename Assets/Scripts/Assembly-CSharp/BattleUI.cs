using System;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class BattleUI : MonoBehaviour
{
	public GameObject temps;

	public JoyStick2D joyStick;

	public float SCREEN_HEIGHT;

	private BossEnter bossEnter;

	private static BattleUI _instance;

	private BattleScreenPanel screenPanel;

	public static BattleUI getInstance()
	{
		return null;
	}

	public BattleScreenPanel GetScreen()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Init()
	{
	}

	public void OnLoadIn(bool isBanPauseBar = false)
	{
	}

	public void OnRestart()
	{
	}

	public void OnCombatWin()
	{
	}

	public void OnCombatLose()
	{
	}

	public GameObject Switch2WinUI()
	{
		return null;
	}

	public GameObject Switch2LoseUI()
	{
		return null;
	}

	public float AddStartAnimation(int level)
	{
		return 0f;
	}

	public GameObject AddClearAnimation()
	{
		return null;
	}

	public void BossEnter(long bossID, Action onCloseEvent = null)
	{
	}

	public GameObject AddFailAnimation()
	{
		return null;
	}

	public void AddSettlementUI(SettlementUI.AnimTypes animType = SettlementUI.AnimTypes.General)
	{
	}

	public void SetCanRecvPlayerTouch(bool state)
	{
	}

	private void ToggleJoyStickLayer(bool state)
	{
	}
}
