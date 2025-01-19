using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class HeroInfoControl : UIPanelBase
{
	public UISprite expBar;

	public UILabel levelLabel;

	public UILabel nameLabel;

	public UILabel expPercentLabel;

	public Transform HeroWidget;

	private GameObject HeadIconPrefab;

	public void SetHeroInfo(UserPlayerHeadIconView _view)
	{
	}

	protected override void Awake()
	{
	}
}
