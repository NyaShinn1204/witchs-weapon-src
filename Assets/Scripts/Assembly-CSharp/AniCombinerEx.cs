using UnityEngine;

public class AniCombinerEx : AniCombiner
{
	private BetterList<Animator> ba;

	private BetterList<ParticleSystem> bp;

	private BetterList<TrailRenderer> tr;

	private BetterList<ShaderAnimator> bs;

	private BetterList<Renderer> br;

	public void ForceResetChildren()
	{
	}

	protected override void SetChildren(bool isForceSet = false)
	{
	}

	private void digui(Transform t)
	{
	}
}
