using UnityEngine;
using unit;

public class InputReciver : MonoBehaviour
{
	public const float CHOOSE_DELAY_TIME = 0.35f;

	public const float TIME_WEIGHT = 1f;

	public const float OFFSET_WEIGHT = 9f;

	public const float RELEASE_SEARCH_RANGE = 1.2f;

	public static InputReciver instance;

	public HeroEntity hero;

	protected RaycastHit hit;

	public virtual void ReleaseMouse()
	{
	}

	protected MonsterEntity SelectMonsterByPos()
	{
		return null;
	}

	public virtual void PressMouse()
	{
	}

	public virtual void MouseDown()
	{
	}

	public virtual void Start()
	{
	}

	public virtual void OnDestroy()
	{
	}
}
