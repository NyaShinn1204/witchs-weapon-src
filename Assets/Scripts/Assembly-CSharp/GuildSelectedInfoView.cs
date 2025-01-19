using UnityEngine;

public class GuildSelectedInfoView : MonoBehaviour
{
	public Transform IconWidget;

	public UILabel Name;

	public UILabel Slogan;

	public UILabel bossInfo;

	public UILabel guildLv;

	public UILabel BuffText;

	public UISprite BuffIcon;

	private GameObject go;

	public UILabel requestRemainTime;

	private void Awake()
	{
	}

	public void SetInfo(GuildSimple info)
	{
	}
}
