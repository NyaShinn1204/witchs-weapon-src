using UnityEngine;

public class AfterBattleQuestItem : MonoBehaviour
{
	public int type;

	public GameObject firstTimeOb;

	public GameObject failOb;

	public GameObject alreadyGetOb;

	public UISprite firstGetReward1;

	public UISprite firstGetReward2;

	public UISprite firstGetReward3;

	public UILabel firstGetTitie;

	public UILabel firstGetName;

	public UISprite alreadyGetReward1;

	public UISprite alreadyGetReward2;

	public UISprite alreadyGetReward3;

	public UILabel alreadyGetName;

	public UILabel alreadyGetTitie;

	public UILabel failName;

	public UILabel failDetailText;

	public UILabel questConditionText;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void InitAndadd(int type, string name, string detail, string failDetail, string loot1Address, string loot2Address, string loot3Address)
	{
	}
}
