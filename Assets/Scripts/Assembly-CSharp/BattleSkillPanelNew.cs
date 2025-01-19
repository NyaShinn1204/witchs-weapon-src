using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class BattleSkillPanelNew : UIPanelSingle
{
	public const float CHANGE_WEAPON_CD = 2f;

	public static SkillInBattleNew Pitching;

	public static BattleSkillPanelNew current;

	public int firstSkillSlotIndex;

	public List<SkillInBattleNew> skillList;

	private Transform durationEmpty;

	private bool isInited;

	private float changeWeaponCD;

	private bool isBindEvent;

	protected override void Awake()
	{
	}

	private void OnWeaponChange(WeaponEvent eve)
	{
	}

	public void SetDefaultSkill(long servantId)
	{
	}

	public void ModeChange(SkillInBattleNew skill)
	{
	}

	public void TryModeChange(SkillInBattleNew skill)
	{
	}

	public void PlayDurationEmptyAnim(BattleSkillPanelNew skill = null)
	{
	}

	private void HideDurationEmptyAnim()
	{
	}

	private void Update()
	{
	}

	private void ReadInputKey()
	{
	}

	private void SimulateClickSkillBtn(int pressedIndex)
	{
	}

	private void SimulateSwapWeapon(int swapIndex)
	{
	}

	private int GetRealSkillSlotIndex(int viewIndex)
	{
		return 0;
	}

	public void OnLoadInBegin()
	{
	}

	public void SetBtnState(int[] args)
	{
	}

	private void RefreshBtnViewByState()
	{
	}
}
