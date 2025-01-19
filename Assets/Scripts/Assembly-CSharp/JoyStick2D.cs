using UnityEngine;

public class JoyStick2D : MonoBehaviour
{
	public HalfColorUISprite fg;

	public HalfColorUISprite bg;

	public HalfColorUISprite bg1;

	protected InputReciverMkII ir2;

	protected bool isPressed;

	public UIRoot rootPanel;

	public float rotSpdCenter;

	public float rotSpdBg;

	public float rotSpdBg1;

	protected float rotSpdRato;

	private Color color
	{
		set
		{
		}
	}

	public virtual void Update()
	{
	}

	public void UpdateScale()
	{
	}

	private void SetScale(Transform t, float scale)
	{
	}

	public Vector3 changePosition(Vector3 pos)
	{
		return default(Vector3);
	}

	public void ReleaseMouse()
	{
	}

	public void MouseDown()
	{
	}

	public void Start()
	{
	}

	public virtual void OnDestroy()
	{
	}
}
