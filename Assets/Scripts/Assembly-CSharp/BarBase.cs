using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BarBase : MonoBehaviour
{
	private const float CHANGE_DURATION = 0.2f;

	public UILabel levelLabel;

	public UILabel maxValueLabel;

	public UILabel valueLabel;

	public UISprite bar;

	public List<BarLevelInfoData> levelInfoList;

	public Dictionary<int, BarLevelInfoData> levelInfoDict;

	public long valueTotal;

	public int level;

	public long value;

	public long cacheValueTotal;

	public int cacheLevel;

	public long cacheValue;

	public int maxLevel;

	protected bool isInit;

	protected Tweener tweener;

	public Action<BarBase> OnLevelChangeEvent;

	public Action<BarBase> OnValueChangeEvent;

	public void Init(int level, long value, List<BarLevelInfoData> levelInfoList)
	{
	}

	public void SetValue(int level, long value, float duration = 0.2f)
	{
	}

	protected virtual void UpdateView(int level, long value)
	{
	}

	protected virtual void UpdateView()
	{
	}

	private int GetLevel(long valueTotal)
	{
		return 0;
	}

	private long GetValue(long valueTotal)
	{
		return 0L;
	}
}
