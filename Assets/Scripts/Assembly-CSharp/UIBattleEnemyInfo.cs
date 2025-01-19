using System.Collections.Generic;
using UnityEngine;

public class UIBattleEnemyInfo : GUtilUISuper
{
	public class ICompareEntity : IComparer<Entity>
	{
		public int Compare(Entity x, Entity y)
		{
			return 0;
		}
	}

	private List<TypeCsvMob> _listEntity;

	private int _listEntityIndex;

	private Transform _viewSelect;

	private Transform _viewInfo;

	private Transform _viewParent;

	private Transform viewSelect
	{
		get
		{
			return null;
		}
	}

	private Transform viewInfo
	{
		get
		{
			return null;
		}
	}

	private Transform viewParent
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

	public void close()
	{
	}

	private void back()
	{
	}
}
