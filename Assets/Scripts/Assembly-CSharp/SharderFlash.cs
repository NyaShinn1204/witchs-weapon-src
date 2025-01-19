using UnityEngine;

public class SharderFlash : MonoBehaviour
{
	private bool _isDestroy;

	private Renderer[] _renderArr;

	private Material[][] _materialArr;

	public float timeTotal;

	public Color fromColor;

	public Color toColor;

	public Color midColor;

	public float midTime;

	public bool isMathMid;

	public bool isCanReflash;

	private float _time;

	public bool isDestroy
	{
		get
		{
			return false;
		}
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void eventAnim()
	{
	}

	public void destroy()
	{
	}
}
