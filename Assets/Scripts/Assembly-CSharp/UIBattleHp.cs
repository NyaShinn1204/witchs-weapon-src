using System.Collections.Generic;

public class UIBattleHp : GUtilUISuper
{
	protected Entity _entity;

	protected UISprite _scrollHP;

	protected UISprite _scrollHP2;

	protected UISprite _viewDef;

	protected UISprite _scrollBG;

	protected UISprite _scrollLight;

	protected List<UISprite> _scrollDef;

	protected float _scrollLightOffset;

	protected float _hpMax;

	protected List<float> _hpDef;

	protected float _alpha;

	private float _hpPre;

	public Entity entity
	{
		get
		{
			return null;
		}
	}

	protected virtual float mathHpMax
	{
		get
		{
			return 0f;
		}
	}

	public virtual float alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected int depth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected override void Start()
	{
	}

	protected override void animShow()
	{
	}

	protected virtual void initView()
	{
	}

	protected virtual void Update()
	{
	}

	protected void eventHP()
	{
	}

	public void hide()
	{
	}

	public void show()
	{
	}
}
