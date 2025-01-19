using UnityEngine;

public class InviteControl : MonoBehaviour
{
	public UIScrollView myScroll;

	public UIScrollView friednScroll;

	public UIGrid myGrid;

	public UIGrid friendGrid;

	public Transform friendProgress;

	public TweenAlpha anim2;

	private bool isMyOpen;

	private bool isFriendOpen;

	private GameObject itemPrefab;

	public TweenAlpha anim1;

	public ButtonEx myBtn;

	public ButtonEx friendBtn;

	public UIInput inviteCode;

	public ButtonEx BindBtn;

	public Transform unBindTrans;

	public Transform bindTrans;

	public UILabel codeText;

	public UILabel desc;

	public InviteView view;

	public Transform myIcon;

	public Transform friendIcon;

	public ButtonEx helpBtn;

	public Transform remindIcon1;

	public Transform remindIcon2;

	private void Awake()
	{
	}

	private void Bind()
	{
	}

	public void ReFresh()
	{
	}

	public void Init()
	{
	}

	private void ClickMyProgress()
	{
	}

	private void ClickFriendPropgress()
	{
	}

	private void CreateMyInviteInfo()
	{
	}

	private void CreateFriendInviteInfo()
	{
	}

	private void OpenAnim1(float _time = 0.15f)
	{
	}

	private void CloseAnim1(float _time = 0.15f)
	{
	}

	private void OpenAnim2(float _time = 0.15f)
	{
	}

	private void CloseAnim2(float _time = 0.15f)
	{
	}
}
