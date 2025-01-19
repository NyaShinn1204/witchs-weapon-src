using System.Collections.Generic;
using UnityEngine;

public class UIScreenAutoSize : MonoBehaviour
{
	public class UIScreenAutoSizeWidget
	{
		public Vector3 initPostion;

		public Vector2 initSize;

		public UIAnchor.Side pivot;
	}

	private Vector2 _screenSize;

	[SerializeField]
	private bool _autoWidth;

	[SerializeField]
	private bool _autoHeight;

	[SerializeField]
	private bool _autoSizeScale;

	private Dictionary<UIWidget, UIScreenAutoSizeWidget> _initDataWidget;

	private bool _isInitData;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void initData()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void resize(UIWidget widget, UIScreenAutoSizeWidget widgetInitData)
	{
	}
}
