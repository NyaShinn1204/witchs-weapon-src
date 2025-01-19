using UnityEngine;

public class QuestFinish : MonoBehaviour
{
	public UILabel nameText;

	public UILabel detailText;

	public UISprite loot1;

	public UISprite loot2;

	public UISprite loot3;

	public TweenPosition toPostion;

	public UISprite star;

	private GameObject target;

	private int starIndex;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetContent(string name, string loot1, string loot2, string loot3, GameObject targetPosition, int index)
	{
	}

	public void SetTargetPostion()
	{
	}
}
