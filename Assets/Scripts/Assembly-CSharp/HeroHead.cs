using UnityEngine;

public class HeroHead : MonoBehaviour
{
	public UISprite iconSprite;

	public UILabel heroLvText;

	public UISlider expSlider;

	public UILabel addExpText;

	public UISprite weaponIcon;

	public UISprite star1;

	public UISprite star2;

	public UISprite star3;

	public UISprite star4;

	public UISprite star5;

	public UISprite frame;

	public UISprite mask;

	public UISprite rank1;

	public UISprite rank2;

	public UISprite rank3;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetHeroData(HeroData data)
	{
	}

	private string GetHeroHeadicon(int id)
	{
		return null;
	}

	private string GetWeaponIcon(int weaponType)
	{
		return null;
	}

	private void SetColorFrame(int color)
	{
	}

	private void SetRank(int color)
	{
	}

	public void SetInfo(string iconName, int heroLv, int addExp, float silderFromm, float sliderTo, int weaponType, int starNum, int rankNum, int color)
	{
	}
}
