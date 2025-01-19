using UnityEngine;

public class WarningAreaSqr : BaseRenderer
{
	public const float DEF_HEIGHT = 12f;

	public const float DEF_WIDTH = 12f;

	public float width;

	public float height;

	public MeshRenderer sqr;

	public float afterdelay;

	protected float timer;

	protected float clipHeight;

	public bool limitByBlock;

	public Color tintColor;

	public PauseType _PauseType;

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

	private void refresh()
	{
	}

	public void Remove()
	{
	}
}
