using UnityEngine;

public class FakeCube : MonoBehaviour
{
	public DHCUISprite front;

	public DHCUISprite top;

	public DHCUISprite side;

	protected float _size;

	public static Vector2 OrthoTransform;

	private Vector3 TLF;

	private Vector3 TRF;

	private Vector3 BLF;

	private Vector3 BRF;

	private Vector3 TLB;

	private Vector3 TRB;

	private Vector3 BLB;

	private Vector3 BRB;

	private Vector2 tlf;

	private Vector2 trf;

	private Vector2 blf;

	private Vector2 brf;

	private Vector2 tlb;

	private Vector2 trb;

	private Vector2 blb;

	private Vector2 brb;

	protected float _rotationY;

	public float size
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float rotationY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void alignBack()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void reset()
	{
	}

	public static Vector2 Fake3DTransformOrtho(Vector3 pos)
	{
		return default(Vector2);
	}
}
