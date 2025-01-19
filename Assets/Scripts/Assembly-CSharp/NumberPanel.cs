using System.Collections.Generic;
using UnityEngine;

public sealed class NumberPanel : MonoBehaviour
{
	public NumberSingle clone;

	private List<NumberSingle> numList;

	private UIPanel uiPanel;

	public static float PanelWidth;

	public static float PanelHeight;

	public static Vector3 PanelMiddle;

	private const float defaultHeightOffset = 1.5f;

	public Transform target;

	private bool isHide;

	private void Start()
	{
	}

	public void Show(long numValue, Transform target, NumberSingle.AnimationTypes animationType, NumberSingle.FontTypes fontType, float heightOffset, NumberSingle.TextTypes textType = NumberSingle.TextTypes.None)
	{
	}

	public void ToggleDmgNum()
	{
	}
}
