using UnityEngine;

public class AniCombiner : MonoBehaviour, IPausedComponent
{
	public const float BRIGHTNESS_TAKE_DAMAGE = 5f;

	public const float BRIGHTNESS_REDUCTION = 25f;

	public static string ShaderStartFilter;

	public static string ExceptionStartFilter;

	public static string ExceptionFilter1;

	public static string ExceptionFilter2;

	public Animator[] _animators;

	public ParticleSystem[] _particles;

	public ShaderAnimator[] _shaderAnimator;

	public Renderer[] _renderers;

	public TrailRenderer[] _trailRenders;

	private float[] _renderBrightnessKeeper;

	public bool _playOnAwake;

	public PauseType _PauseType;

	public float maxTrailTime;

	protected float[] _trailTimes;

	private float _timePauseBegin;

	private float _timeAfterResume;

	private float _delayTime;

	private float _pauseEndTime;

	private float _brightness;

	private bool shouldPause
	{
		get
		{
			return false;
		}
	}

	private float brightness
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected virtual void SetChildren(bool isForceSet = false)
	{
	}

	public void Play()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void greyMats(bool grey)
	{
	}

	public float GetBrightnessOfRenderer(Renderer renderer)
	{
		return 0f;
	}

	public void setBrightness(float b)
	{
	}

	private void OnApplicationQuit()
	{
	}
}
