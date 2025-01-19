using UnityEngine;

public class HealthBar : MonoBehaviour
{
	public UISprite hp;

	public UISprite hp_dark;

	public UILabel hp_text;

	public UILabel hp_minus;

	public UISprite hp_bg;

	public const float PERCENT_START = 0f;

	public const float PERCENT = 1f;

	protected float m_hpMax;

	protected float m_hpCurr;

	protected float m_percentCurr;

	protected const int HP_WIDTH = 306;

	private const float DELAY = 0.16f;

	private float spd;

	private float delay_timer;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SetTextInfo()
	{
	}

	public void setText(float hpMax, float hpCurr)
	{
	}

	private void Update()
	{
	}
}
