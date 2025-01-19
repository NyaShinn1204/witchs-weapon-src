using UnityEngine;
using WaterBell.ProjX.Level.Event;

public class ParticlesCoin : ProgrameParticleBase
{
	protected Vector3 currentfocus;

	protected Vector3 currentPosition;

	protected const float focusSpd = 4f;

	protected float splashRad;

	protected const float gravity = 35f;

	protected const float resistance0 = 1.8f;

	protected const float resistance = 6f;

	protected const float aSpeed = 3f;

	protected static ParticlesCoin instance;

	protected BetterList<PosAndFocus> initList;

	protected PosAndFocus currItem;

	public Shadow shadow;

	private RaycastHit tempHit;

	private Vector3 tempPos;

	private Vector3 tempASpd;

	protected override void Awake()
	{
	}

	protected override void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public static ParticlesCoin getInstance()
	{
		return null;
	}

	protected override void globalRefresh()
	{
	}

	public void emit(int count, Vector3 position, Vector3 focus)
	{
	}

	protected override void createNew()
	{
	}

	public static void Emit(int count, Vector3 position, Vector3 focus)
	{
	}

	protected override void reinitParticle(int index)
	{
	}

	private void OnPlayerExitBattleFieldFromArea(PlayerExitBattleFieldFromAreaEvent e)
	{
	}

	public void Reset()
	{
	}

	protected void resetParticle(int index, Vector3 pos, Vector3 focus)
	{
	}

	protected override void refreshParticleAt(int i)
	{
	}

	protected override void recycleParticleAt(int i)
	{
	}
}
