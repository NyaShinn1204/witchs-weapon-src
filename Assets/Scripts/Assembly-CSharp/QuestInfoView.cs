using System.Collections.Generic;
using UnityEngine;

public class QuestInfoView : QuestInfoViewViewBase
{
	public int serialNum;

	public UILabel _name;

	public UISprite _icon;

	public UILabel _condition;

	public UILabel _conditionCount;

	public UITable _reward;

	public UISprite bgTypeIcon;

	public Transform topBg;

	public GameObject bgIcon;

	private List<DrawResultData> rl;

	public ButtonEx getAwardBtn;

	public Transform unGetAwardBtn;

	public ButtonEx goBtn;

	public Transform lockBg;

	public override void GuideChanged(bool value)
	{
	}

	public override void StatusChanged(int value)
	{
	}

	public override void MetaChanged(int value)
	{
	}

	public override void ValidChanged(int value)
	{
	}

	public override void Awake()
	{
	}

	private void GoTo()
	{
	}

	public override void Start()
	{
	}

	private void SetInfo()
	{
	}

	private void TaskOnClick()
	{
	}

	public void SetReward(QuestData _info, UITable trans)
	{
	}

	private void ChangeStatus(int _status)
	{
	}

	public void SetItem(Transform tran, DrawResultData data)
	{
	}
}
