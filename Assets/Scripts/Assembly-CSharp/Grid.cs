using UnityEngine;

public class Grid : GridBaseOnOffset
{
	protected const float nPANEL_RADIUS = 850f;

	protected const float nCENTER_X = 770f;

	protected const float nCENTER_Y = 320f;

	public const float nBUTTON_RADIUS = 0.18151423f;

	public BetterList<MainBtn> btnList;

	public const string FRAGMENT = "main_btn_fragment";

	public const string SOULS = "main_btn_souls";

	public const string SOCIAL = "main_btn_social";

	public const string SHOP = "main_btn_shop";

	public const string LOTTERY = "main_btn_lottery";

	public const string INSTANCE = "main_btn_instance";

	public const string EQUIPMENT = "main_btn_equipment";

	public const string MENU = "main_btn_menu";

	public const string EXIT = "main_btn_exit";

	public string[] btnNames;

	public override float spacing
	{
		get
		{
			return 0f;
		}
	}

	protected override void Awake()
	{
	}

	private void createBtn(int index)
	{
	}

	protected override void Start()
	{
	}

	public override void refreshChildAt(int index)
	{
	}

	protected float getCurrRad(float rad)
	{
		return 0f;
	}

	protected float getCurrScale(float rad)
	{
		return 0f;
	}

	public override void move(Vector3 vec)
	{
	}

	private void btnClicked(GameObject go)
	{
	}

	private void autoMoveComplete()
	{
	}
}
