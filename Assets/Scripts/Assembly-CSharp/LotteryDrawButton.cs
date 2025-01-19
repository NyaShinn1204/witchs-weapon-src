using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class LotteryDrawButton : MonoBehaviour
{
	private UISprite _OneIcon;

	private UILabel _OneCurreny;

	private UILabel _OneFreeLabel;

	private UILabel _OneTitle;

	private UISprite _OneSprite;

	private UISprite _TenIcon;

	private UILabel _TenCurreny;

	private UILabel _TenFreeLabel;

	private UILabel _TenTitle;

	private UISprite _TenSprite;

	private DrawInfo _Data;

	private string _StrFree;

	private string _StrWillFree;

	private string _StrWarningClose;

	private void Start()
	{
	}

	private bool IsClosePerson()
	{
		return false;
	}

	public void Click(GameObject obj)
	{
	}

	public void UpdateInfo(DrawInfo drawInfo)
	{
	}

	private void Update()
	{
	}
}
