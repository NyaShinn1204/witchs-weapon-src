using System.Collections.Generic;
using Cscmod;
using UnityEngine;
using WaterBell.LevelDesign;
using WaterBell.ProjX.Playmode;

public class DebugCore : MonoBehaviour
{
	private static DebugCore _instance;

	private static string defaultAccFileName;

	public static Dictionary<string, bool> accCacheRecordDict;

	public CoreLevelArranger clArranger;

	private AccountDataRow currAccDR;

	public SelectLevelDataModel slDM;

	public PlayerCfgSimulator simulator;

	public AccountConfig accConfig;

	public UIInput svIDInput;

	public UIPopupList accPL;

	public UIPopupList levelSetPL;

	public UIPopupList levelDetailPL;

	public UIButton btnGo;

	public UIButton btnResetCore;

	public Transform tf_SVCheckList;

	private bool isStartBtnProessing;

	private DebugExpeditionMode debugMode;

	public CscInstance cscInstance { get; set; }

	public static DebugCore GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void FillInitInfo()
	{
	}

	private void FillCoreAccInfo()
	{
	}

	private void Switch2NewAcc()
	{
	}

	private void FillCoreLevelInfo()
	{
	}

	private void updateAvailableCoreLevel(long levelSetID)
	{
	}

	private void Update()
	{
	}

	public void OnAccountSetSelectionChanged()
	{
	}

	public void OnEnergyRegenSelectionChanged()
	{
	}

	public void OnOneHitKillSelectionChanged()
	{
	}

	public void OnInitalFullEnergySelectionChanged()
	{
	}

	public void OnAllowHideUIChanged()
	{
	}

	public void OnDisableMixedAIProxyChanged()
	{
	}

	public void OnSvAdjustCheckChanged()
	{
	}

	public void OnConnRemoteServerSelectionChanged()
	{
	}

	public void OnLogVisiableChanged()
	{
	}

	public void OnDynamicEnemyCheckBoxChanged()
	{
	}

	public void ClickReset()
	{
	}

	public void ClickBattle()
	{
	}

	public void ClickChest()
	{
	}

	public void OnCoreHttpInitFinished()
	{
	}

	public void OnExpeditionStateUpdate()
	{
	}

	public void OnReassignCoreLevelFinished()
	{
	}

	private void saveDefaultAcc(int idx)
	{
	}

	private int loadDefaultAccIdx()
	{
		return 0;
	}

	internal void updateServants()
	{
	}

	private void OnCoreHttpUpdateServantsFinished()
	{
	}

	internal void ReassignExpeditionNodes(string[] ids)
	{
	}

	public void ReassignExpeditionProgressIndex(int jumpLevelProgressIndex)
	{
	}

	private string doSerialize(CscInstance obj)
	{
		return null;
	}
}
