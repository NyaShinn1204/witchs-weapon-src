using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class GuildBuffItem : MonoBehaviour
{
	public ButtonEx changeBtn;

	public ButtonEx activeBtn;

	public UISprite buffIcon;

	public UILabel buffText;

	public UILabel payDonateValue;

	public Transform closeBg;

	public UILabel TimeLabel;

	private int buffID;

	public static GuildBuffItem currentBuff;

	private long buffTime;

	private void Awake()
	{
	}

	public void SetInfo(GuildBuffData _data, bool _IsCD, bool _IsLook)
	{
	}

	private void Active()
	{
	}

	private void SetTime(int _id)
	{
	}

	private void OnDisable()
	{
	}

	private void BuffTime()
	{
	}

	private void SetBtnUI(bool _IsExsitBuff, bool _IsLook)
	{
	}
}
