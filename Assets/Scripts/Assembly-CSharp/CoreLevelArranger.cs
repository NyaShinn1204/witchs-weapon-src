using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class CoreLevelArranger : MonoBehaviour
{
	public static readonly int maxCoreLevelNum;

	public static readonly int chestPerCoreLevelNum;

	public static readonly int chestPerSlotNum;

	private static CoreLevelArranger _instance;

	private Expedition e;

	public GameObject origCoreLevelGrid;

	public GameObject coreLevelSlotGrid;

	public GameObject coreLevelSaveGrid;

	public UIButton reassignCoreLevelBtn;

	private List<long> availableLevelIDList;

	private Dictionary<long, int> availableLevelIDDict;

	private List<string> availableLevelNameList;

	private List<int> currCoreLevel;

	private bool isSync;

	public UILabel combatScoreValLabel;

	public GameObject jumpInfoRegion;

	public string currLevelInstanceIDStr;

	public UILabel currLevelLabel;

	public UILabel jumpLevelLabel;

	public UIButton jump2CoreLevelBtn;

	private int jumpLevelProgressIndex;

	public UIButton goBattleBtn;

	public UIButton goChestBtn;

	private GameObject coreLevelLabel;

	private GameObject coreLevelFightSlot;

	private GameObject coreLevelSaveSlot;

	private Color origCol;

	private Color markedCol;

	private int maxTempSaveNum;

	public static CoreLevelArranger GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void LoadFinished()
	{
	}

	public void AddAvailableCoreLevel(int idx, long id, string name)
	{
	}

	public void LoadSaveRecords()
	{
	}

	public bool TryAppendCoreLevel(int levelIdx)
	{
		return false;
	}

	private void OnOrigCoreLevelLabelClick(int clickIdx)
	{
	}

	private void OnCoreLevelNameBtnClick(CoreLevelFightSlot slot)
	{
	}

	private void OnCoreLevelUpBtnClick(CoreLevelFightSlot slot)
	{
	}

	private void OnCoreLevelDownBtnClick(CoreLevelFightSlot slot)
	{
	}

	private void OnCoreLevelRmBtnClick(CoreLevelFightSlot slot)
	{
	}

	private void SwapSlot(CoreLevelFightSlot fromSlot, CoreLevelFightSlot toSlot)
	{
	}

	private void RmSlot(CoreLevelFightSlot rmSlot)
	{
	}

	private void RebuildSlotFromSave(CoreLevelSaveSlot saveSlot)
	{
	}

	public void FillTempSaveList()
	{
	}

	private void appendTempSave(int i)
	{
	}

	private void OnCoreLevelSaveLoadClick(CoreLevelSaveSlot saveSlot)
	{
	}

	private void OnCoreLevelSaveWriteClick(CoreLevelSaveSlot saveSlot)
	{
	}

	private void OnCoreLevelSaveClearClick(CoreLevelSaveSlot saveSlot)
	{
	}

	private void initAid()
	{
	}

	private void OnReassignCoreLevelBtnClick()
	{
	}

	private void OnJumpCoreLevelBtnClick()
	{
	}

	public void OnReassignProgressIndex()
	{
	}

	public void OnUpdateCombatScore(string csVal)
	{
	}

	public void RebuildSlotFromSyncData()
	{
	}

	private void GetSyncData()
	{
	}

	public void SetSyncAndUI(bool sync)
	{
	}

	private int ConvertExpeditionIdx2SlotIdx()
	{
		return 0;
	}

	private int ConvertSlotIdx2ExpeditionIdx(int slotIdx)
	{
		return 0;
	}

	public bool GetIsSync()
	{
		return false;
	}
}
