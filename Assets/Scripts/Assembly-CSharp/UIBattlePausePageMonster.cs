using System.Collections.Generic;
using UnityEngine;
using unit;

public class UIBattlePausePageMonster : UIBattlePausePage
{
	public class ICompareEntity : IComparer<Entity>
	{
		public int Compare(Entity x, Entity y)
		{
			return 0;
		}
	}

	private List<MonsterEntity> _listEntity;

	private int _listEntityIndex;

	private Transform _viewSelect;

	private UIPageMonsterInfo _viewInfo;

	private List<GameObject> _listIcon;

	private Transform viewSelect
	{
		get
		{
			return null;
		}
	}

	protected override void Start()
	{
	}

	private void initView()
	{
	}

	private void showMonsterInfo()
	{
	}

	private void animMonsterView()
	{
	}

	private void icon(string[] sArg)
	{
	}

	public override void destroy()
	{
	}
}
