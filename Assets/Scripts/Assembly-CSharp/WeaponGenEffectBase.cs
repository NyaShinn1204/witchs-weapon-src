using UnityEngine;

public class WeaponGenEffectBase : EffectBase
{
	public enum EffectTarget
	{
		AtkTarget = 0,
		PlayerSelf = 1
	}

	public EffectTarget effTarget;

	public bool isIndependentEff;

	public bool isEffOnGround;

	public bool isAlign2PlayerRotation;

	private GameObject proxyObject;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void Bind(EffectsBander effectsBander, CharacterBase source, Transform faceTo = null)
	{
	}

	public override void Sucide()
	{
	}
}
