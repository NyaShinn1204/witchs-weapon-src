using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class InviteItem : MonoBehaviour
{
	public ButtonEx getAwardBtn;

	public ButtonEx lockBtn;

	public ButtonEx finishBtn;

	public UILabel desc;

	public Transform item;

	private GameObject itemPrefab;

	private bool isBeInvite;

	private long id;

	private long descID;

	private void Awake()
	{
	}

	public void SetInfo(InviteRewardInfo _info, bool _isBeInvite)
	{
	}
}
