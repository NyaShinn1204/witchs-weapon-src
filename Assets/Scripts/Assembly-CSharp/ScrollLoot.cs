using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ScrollLoot : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void EventClick(int _index);

	private static ScrollLoot current;

	private UIScrollView scroll;

	private UIWrapContent wrap;

	private UICenterOnChild child;

	private List<Texture> list;

	private Transform currentItem;

	private UITable indexTable;

	private float offset;

	private float repeatOffset;

	private int currentIndex;

	private const string sprite1 = "zhujiemian_dian";

	private const string sprite2 = "zhujiemian_lunbo_dian01";

	private float repeatRateTime;

	private float strength;

	private const string prefabPath = "UI/Prefab/ScrollPanel";

	public Vector2 textureSize;

	public Vector3 mPosition;

	private string atlasPath;

	private Vector2 indexTablePadding;

	private GameObject obj;

	private UIScrollView dragScroll;

	private ButtonEx clickBtn;

	public EventClick clickTv;

	public static ScrollLoot GetInstance()
	{
		return null;
	}

	private void Init()
	{
	}

	private void DragEvent()
	{
	}

	public void SetScrollLoot(Transform _parent, UIScrollView.Movement _currentMovement, Vector2 _clippingSize, List<Texture> _list, EventClick _click)
	{
	}

	private void StartLoot()
	{
	}

	private void Awake()
	{
	}

	private void OnCenterChild(GameObject _go)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void InitAutoMove()
	{
	}

	private void AutoMoveTv()
	{
	}

	private void MoveTv(bool _next = true)
	{
	}

	private void UpdateItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	private void ResetIndex(int _index)
	{
	}

	private void OnDisable()
	{
	}

	public void DestoryScrollLoot()
	{
	}
}
