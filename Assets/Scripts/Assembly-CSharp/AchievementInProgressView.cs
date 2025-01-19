using System.Collections.Generic;
using UnityEngine;

public class AchievementInProgressView : AchievementInProgressViewViewBase
{
	public UISprite Icon;

	public UILabel Name;

	public long Id;

	public UILabel Progress;

	public UILabel Condition;

	public UITable Reward;

	private float value;

	public UILabel descText;

	public ButtonEx getAwardBtn;

	public Transform finishAchievBg;

	private List<DrawResultData> rl;

	private GameObject prefab;

	public int serialNum;

	public override void AchievementInProgressInfoChanged(AchievementData value)
	{
	}

	public override void Start()
	{
	}

	private void SetUI(AchievementData _value)
	{
	}

	public void SetReward(AchievementData _info, UITable trans)
	{
	}

	private string GetFinishNumber(AchievementData achie)
	{
		return null;
	}

	public void GetCurrentReward()
	{
	}

	public void ShowFallPanel(long id)
	{
	}

	public void SetItem(Transform tran, DrawResultData data)
	{
	}
}
