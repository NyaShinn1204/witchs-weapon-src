using UnityEngine;

public class FallPanelControl : CommonScenePanel
{
	public static FallPanelControl current;

	private GameObject item;

	public Transform grid;

	public ButtonEx close;

	public GameObject specialIcon;

	private int BeforeLv;

	private int AfterLv;

	private int BeforeStamina;

	private int AfterStamina;

	private bool isUp;

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	public void ShowQuastFallItem(long questID)
	{
	}

	public void ShowQuastFallItem(long questID, int bLV, int aLV, int bVIT, int aVIT)
	{
	}

	public void ShowSignLoot(int day)
	{
	}

	public void ShowPayLoot(ModelCollection<DrawResultData> datas)
	{
	}

	public void ShowShopFallItem(ModelCollection<DrawResultData> datas)
	{
	}

	private void SetInfo(Transform tran, DrawResultData data)
	{
	}

	private void SetChest(Transform tran, int type, long id, int value, int num)
	{
	}

	private void SetItemType(int ItemType, int rank, UISprite _iconFrame, UISprite _iconBg, UISprite _iconRank)
	{
	}

	public void Close()
	{
	}
}
