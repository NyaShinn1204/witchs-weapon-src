public class UIBattleHpPlayer : UIBattleHp
{
	private UILabel _labelMul;

	private UILabel _labelNum;

	private UISprite _iconBattleEnvironment;

	private bool _isShowSwitchWeapon;

	public override float alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override float mathHpMax
	{
		get
		{
			return 0f;
		}
	}

	public static UIBattleHpPlayer ApplyEnemyHpTo(Entity target)
	{
		return null;
	}

	protected override void initView()
	{
	}

	protected override void Update()
	{
	}

	private void eventLabel()
	{
	}
}
