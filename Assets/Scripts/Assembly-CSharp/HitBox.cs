using System.Runtime.InteropServices;
using UnityEngine;

public class HitBox : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void voidDelegate();

	public bool Lock;

	private bool _isPressed;

	private static HitBox _instance;

	public voidDelegate onPress;

	public voidDelegate onRelease;

	public voidDelegate onMouseDown;

	protected int _currentTouchID;

	protected static int _defaultTouchID;

	public int currentTouchID
	{
		get
		{
			return 0;
		}
	}

	public static HitBox GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void eventInput()
	{
	}

	private void OnPressInputChange(bool sIsPress)
	{
	}
}
