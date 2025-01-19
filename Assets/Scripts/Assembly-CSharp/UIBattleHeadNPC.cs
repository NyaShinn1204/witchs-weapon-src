using System.Collections.Generic;
using UnityEngine;

public class UIBattleHeadNPC : GUtilUISuper
{
	private class UIBattleHeadNPCData
	{
		private Entity _entity;

		public GameObject view;

		private UISprite _viewHPScroll;

		private UISprite _viewDeath;

		private bool _isSummon;

		public UIBattleHeadNPCData(GameObject sView, Entity sEntity)
		{
		}

		public bool eventUpdate()
		{
			return false;
		}

		public void destory()
		{
		}
	}

	private float _size;

	private bool _isShow;

	private List<UIBattleHeadNPCData> _data;

	private UIPanel _panel;

	protected override void Start()
	{
	}

	private void initView()
	{
	}

	private void Update()
	{
	}

	public void clearData()
	{
	}

	public void addData(Entity sEntity)
	{
	}

	private void btnShow()
	{
	}

	public void show()
	{
	}

	public void hide()
	{
	}
}
