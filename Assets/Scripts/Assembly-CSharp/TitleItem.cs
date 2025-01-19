using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class TitleItem : MonoBehaviour
{
	public Transform unLockType;

	public Transform lockType;

	public Transform selectBg;

	public UILabel lockDescText;

	public UILabel unLockDescText;

	public ButtonEx Btn;

	private static TitleItem currentTitle;

	private long titleID;

	private bool unLock;

	private void Awake()
	{
	}

	public void SetInfo(UserTitle _title)
	{
	}

	private void Select()
	{
	}
}
