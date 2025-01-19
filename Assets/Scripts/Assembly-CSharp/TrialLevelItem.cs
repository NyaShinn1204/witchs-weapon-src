using UnityEngine;

public class TrialLevelItem : MonoBehaviour
{
	public ButtonEx btn;

	public Transform lockImg;

	public UILabel levelText;

	public Transform selectImg;

	public UISprite bg;

	public Transform reward;

	public long id;

	private int lockType;

	private int itemIndex;

	public static TrialLevelItem current;

	private float tweenTime;

	private TweenScale tw;

	public UILabel instanceName;

	public UILabel instanceDifficulty;

	public UISprite img;

	private void Awake()
	{
	}

	public void SetInfo(DailyInstanceViewModel _level, int _index)
	{
	}

	private void SelectLevel()
	{
	}

	public void UnSelect()
	{
	}

	public void Select()
	{
	}
}
