using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BattleNumberPanel : MonoBehaviour
{
	public static BattleNumberPanel current;

	private static int itemDepth;

	private static readonly Vector3 roleHeadOffset;

	public float gravity;

	public float speed;

	public float tiltMax;

	public float tiltMin;

	public float speedDirRandom;

	public float speedRandom;

	public BattleNumberItem cloneSourece;

	public List<BattleNumberItem> poolList;

	public Camera uiCamera;

	public Camera targetCamera;

	private Dictionary<Transform, List<DamageInfo>> damageInfoDict;

	[SerializeField]
	public List<DamageInfo> testInfoList;

	public float speedScaleX;

	[NonSerialized]
	public UIAtlas languageAtlas;

	public UIAtlas numberAtlas;

	private void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public void Show(DamageInfo damageInfo)
	{
	}

	[DebuggerHidden]
	private IEnumerator ShowNums()
	{
		return null;
	}

	private List<BattleNumberItem> CreatNums(List<DamageInfo> damageInfoList)
	{
		return null;
	}

	private void ClearDamageInfo()
	{
	}

	public void Push(BattleNumberItem num)
	{
	}
}
