using System.Collections.Generic;
using UnityEngine;

public class UIBuffBattle : MonoBehaviour
{
	public class ItemView
	{
		public int frame;

		public BuffEntity buff;

		public GameObject view;

		public UISprite fore;

		public UISprite icon;

		public List<UISprite> num;

		private string _preLayerCount;

		public void drawNum(int type)
		{
		}

		public void animShow()
		{
		}

		public void animRemove()
		{
		}

		private void animRemoveHD()
		{
		}

		public void animBreak()
		{
		}
	}

	public class ICompareItemView : IComparer<ItemView>
	{
		public int Compare(ItemView x, ItemView y)
		{
			return 0;
		}
	}

	private static int _IDSign;

	private List<ItemView> _data;

	private Vector3 _offset;

	private Dictionary<BuffEntity, ItemView> _dataBuff;

	private int _size;

	private Entity _entity;

	private bool _isPlayer;

	public static int IDSign
	{
		get
		{
			return 0;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void eventBuffData()
	{
	}

	private void eventView()
	{
	}

	private void drawIcon(ItemView sItemView)
	{
	}

	private Vector3 mathPosition(int sIndex)
	{
		return default(Vector3);
	}

	protected static UISprite createSprite(Transform sParent, UIAtlas sAtla, string sSprite)
	{
		return null;
	}
}
