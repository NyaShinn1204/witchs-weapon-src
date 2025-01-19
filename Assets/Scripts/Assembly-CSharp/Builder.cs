using UnityEngine;

public class Builder : MonoBehaviour
{
	public EffectBase[] effects;

	public string controller;

	public GameObject father;

	public WeaponType weaponType;

	public int attackLines;

	public int[] attackStartDash;

	public string[] attackStartDashString;

	public int[] attackStartStand;

	public string[] attackStartStandString;

	public int[] attackMid;

	public int[] attackEnd;

	public int currentLine;

	protected Animator animator;

	protected HeroEntity hero;

	protected AnimatorController animatorController;

	protected int subscript;

	protected int attackTime;

	public int Init(GameObject fa, WeaponType wpType)
	{
		return 0;
	}

	public void Sucide()
	{
	}

	private int getRandomInt(int[] array, int lineCount)
	{
		return 0;
	}
}
