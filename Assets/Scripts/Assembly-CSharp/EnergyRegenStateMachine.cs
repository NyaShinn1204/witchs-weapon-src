using System.Collections;
using System.Diagnostics;
using WaterBell.ProjX.Battle.Event;

public class EnergyRegenStateMachine
{
	public enum Mode
	{
		DeActived = 0,
		Actived = 1,
		Fading = 2
	}

	private const float CountDownTime = 1.5f;

	private const int FPS = 30;

	private HeroEntity role;

	private Mode mode;

	private readonly int origCountdownFrame;

	private int currCountdownFrame;

	public bool isRegenActived
	{
		get
		{
			return false;
		}
	}

	public Mode currState
	{
		get
		{
			return default(Mode);
		}
	}

	public EnergyRegenStateMachine(HeroEntity h)
	{
	}

	public int GetCurrCountdownFrame()
	{
		return 0;
	}

	public void Reset()
	{
	}

	public void AddListener()
	{
	}

	private void StartTimer()
	{
	}

	private void CancelTimer()
	{
	}

	[DebuggerHidden]
	private IEnumerator RegenDeactiveTimeCountDown()
	{
		return null;
	}

	private void DeactiveEnergyRegen()
	{
	}

	private void OnEnergyRegenActive(EnergyRegenActiveEvent e)
	{
	}

	private void OnEnergyRegenFadeout(EnergyRegenFadeoutEvent e)
	{
	}
}
