using Google.Protobuf.Collections;
using Lootmod;
using UnityEngine;

public class LotteryDebugPanel : MonoBehaviour
{
	public static LotteryDebugPanel current;

	private UIInput _DrawCountInput;

	private UIGrid _Grid;

	private GameObject _ResultPanel;

	private GameObject _InputPanel;

	private Transform _SSRTrs;

	private Transform _HeadTrs;

	private Transform _FashionTrs;

	private UILabel _SSRLabel;

	private UILabel _HeadLabel;

	private UILabel _FashionLabel;

	private UILabel _TipsLabel;

	private UILabel _FristSSRLabel;

	private Transform _IndexLabel;

	private long _DrawItemID;

	private int _FristSSR;

	private bool _CanReDraw;

	public static void Show()
	{
	}

	private void Start()
	{
	}

	private void OnDestory()
	{
	}

	private void LogError(string str)
	{
	}

	private void HideOrShow(bool tag)
	{
	}

	private void Draw(GameObject obj)
	{
	}

	public void ShowResult(RepeatedField<LootObject> loots)
	{
	}
}
