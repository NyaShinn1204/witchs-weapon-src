using System.Collections.Generic;
using UnityEngine;

public class UIScreenAutoSize4Panel : MonoBehaviour
{
	public class UIScreenAutoSizeWidget
	{
		public Vector3 initPostion;

		public Vector2 initSize;

		public Vector2 initOffset;

		public UIAnchor.Side pivot;
	}

	private Vector2 _screenSize;

	[SerializeField]
	private bool _autoWidth;

	[SerializeField]
	private bool _autoHeight;

	[SerializeField]
	private bool _autoSizeScale;

	[SerializeField]
	private UIAnchor.Side _autoPivot;

	private Dictionary<UIPanel, UIScreenAutoSizeWidget> _initDataPanel;

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

	private void resize(UIPanel panel, UIScreenAutoSizeWidget widgetInitData)
	{
	}
}
