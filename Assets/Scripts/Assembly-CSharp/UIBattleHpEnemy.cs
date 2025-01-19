using System.Collections.Generic;
using UnityEngine;
using unit;

public class UIBattleHpEnemy : UIBattleHp
{
	public class ICompareUIBattleHpEnemy : IComparer<UIBattleHpEnemy>
	{
		public int Compare(UIBattleHpEnemy x, UIBattleHpEnemy y)
		{
			return 0;
		}
	}

	public const float HEIGHT_OFFSET = 0.7f;

	protected GameObject _viewSkill;

	private static int _depthMathFrame;

	private Vector3 _offset;

	protected GameObject _scrollLine;

	public Entity.MonsterEntityHPUIType enemyType
	{
		get
		{
			return default(Entity.MonsterEntityHPUIType);
		}
	}

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

	public static UIBattleHpEnemy ApplyEnemyHpTo(MonsterEntity target)
	{
		return null;
	}

	public static void ApplyEnemySkillLoading(Entity sTarget, float sTime, long sIDSkill)
	{
	}

	public static void RemoveEnemySkillLoading(Entity sTarget)
	{
	}

	private static void eventDepth()
	{
	}

	protected override void animShow()
	{
	}

	protected override void initView()
	{
	}

	private bool isKillTarget()
	{
		return false;
	}

	protected override void Update()
	{
	}

	protected virtual void eventPosition()
	{
	}

	protected virtual void eventDestroy()
	{
	}
}
