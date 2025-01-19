using UnityEngine;
using WaterBell.LevelDesign;
using WaterBell.ProjX.Playmode;
using WaterBell.ProjX.View.Panel;

public class DebugBattle : MonoBehaviour
{
	public SelectLevelDataModel slDM;

	public PlayerCfgSimulator simulator;

	public AccountConfig accConfig;

	public UIPopupList accPL;

	public UIPopupList levelSetPL;

	public UIPopupList levelDetailPL;

	public UIButton btnGo;

	public Transform tf_SVCheckList;

	private bool isInitedData;

	public SelectCardsController selectCardPanelCtrl;

	private DebugNormalMode debugMode;

	public ButtonEx charpterBtn;

	public DebugSelectCharpter selectCharpterPanel;

	private void Awake()
	{
	}

	private void InitCharpterInfos()
	{
	}

	private void Start()
	{
	}

	private void FillInitInfo()
	{
	}

	private void FillAccInfo()
	{
	}

	private void FillLevelInfo()
	{
	}

	public void updateLevelDetailSelector(long levelSetID)
	{
	}

	public void OnAccountSetSelectionChanged()
	{
	}

	public void OnLevelSetSelectionChanged()
	{
	}

	public void OnLevelSetDetailSelectionChanged()
	{
	}

	public void OnUseLocalJsonSelectionChanged()
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

	public void OnConnRemoteServerSelectionChanged()
	{
	}

	public void OnLogVisiableChanged()
	{
	}

	public void OnDynamicEnemyCheckBoxChanged()
	{
	}

	public void ClickBattle()
	{
	}
}
