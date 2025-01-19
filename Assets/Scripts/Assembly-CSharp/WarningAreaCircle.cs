using UnityEngine;

public class WarningAreaCircle : BaseRenderer
{
	public float halfSideAngles;

	public float radius;

	public GameObject leftLine;

	public GameObject rightLine;

	public MeshRenderer leftLR;

	public MeshRenderer rightLR;

	public MeshRenderer round;

	public const float DEF_RADIUS = 6f;

	public float afterdelay;

	protected float timer;

	protected float clipRadius;

	public bool limitByBlock;

	public PauseType _PauseType;

	public Color tintColor;

	private float runingTime;

	private void Start()
	{
	}

	public void OnBreak(CharacterBase cb)
	{
	}

	private void Update()
	{
	}

	private void reset()
	{
	}

	private void setColor(Color c)
	{
	}

	private void refresh()
	{
	}

	public void Remove()
	{
	}
}
