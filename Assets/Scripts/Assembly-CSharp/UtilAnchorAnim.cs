using System.Collections.Generic;
using UnityEngine;

public class UtilAnchorAnim : MonoBehaviour
{
	public UIAnchor[] anchor;

	public bool awaysAnimShow;

	private Dictionary<Transform, UIAnchor.Side> _hashSide;

	private Dictionary<Transform, Vector3> _hashPosition;

	private bool _isHide;

	private bool _isInit;

	private float _time;

	private float _offset;

	private void Awake()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
