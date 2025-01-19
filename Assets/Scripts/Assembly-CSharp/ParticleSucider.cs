using System.Collections.Generic;
using UnityEngine;

public class ParticleSucider : MonoBehaviour
{
	public bool deadafterlife;

	public float stopTime;

	public float sucideTime;

	private float _elapsedTime;

	private bool _isStop;

	private List<ParticleSystem> _particleSystemArr;

	private bool isDestoried;

	private bool shouldReturn;

	private string poolName;

	private EffectBase res;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void stop()
	{
	}

	public virtual void destroy()
	{
	}

	public void SetReturn(string poolname, EffectBase res)
	{
	}

	public void Reset()
	{
	}

	public void Resettime()
	{
	}

	private void Resume()
	{
	}
}
