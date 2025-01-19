using UnityEngine;

public class ProgrameParticleBase : MonoBehaviour, IPausedComponent
{
	public const int FOREGOUND = 3500;

	protected Vector3 scaleToGlobal;

	protected ParticlesControllerEx mParticlesController;

	public BetterList<ParticleEx> particlesEx;

	protected BetterList<int> trash;

	public bool autoSucide;

	protected int particlesNum;

	protected int particlesNumWorking;

	private float focus;

	private float baseSpd;

	public PauseType _PauseType;

	protected ParticleSystem ps;

	protected virtual void Awake()
	{
	}

	private void Start()
	{
	}

	protected virtual void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public virtual void kill(int index)
	{
	}

	protected virtual void globalRefresh()
	{
	}

	protected virtual void sucide()
	{
	}

	protected virtual void refreshParticleAt(int i)
	{
	}

	protected virtual void recycleParticleAt(int i)
	{
	}

	protected void initParticle()
	{
	}

	protected virtual void reinitParticle(int index)
	{
	}

	protected virtual void createNew()
	{
	}

	public virtual bool particleIsEnable(int index)
	{
		return false;
	}
}
