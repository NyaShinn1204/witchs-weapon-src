using UnityEngine;

public class ServantDevelopPanelController : MonoBehaviour
{
	public enum CurrentTab
	{
		main = 0,
		summary = 1,
		skill = 2,
		favor = 3,
		weapon = 4,
		stars = 5
	}

	public GameObject Main;

	public GameObject Summary;

	public GameObject Skill;

	public GameObject Favor;

	public GameObject Weapon;

	public GameObject Stars;

	public static ServantDevelopPanelController current;

	public CurrentTab current_tab;

	private void Start()
	{
	}

	public void FreshChildPanel()
	{
	}
}
