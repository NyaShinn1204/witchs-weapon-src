using System.Runtime.InteropServices;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;

public class RuneBtnInfo : MonoBehaviour
{
	public enum runeState
	{
		Equipped = 0,
		UnEquipped = 1,
		Lock = 2
	}

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void clickBtn(int i);

	public runeState currentState;

	private clickBtn delegateClick;

	private int index;

	public Transform equipped;

	public Transform unEquipped;

	public Transform lockTran;

	public Transform runeItemTran;

	private GameObject runeItem;

	private RuneInfoDetail detail;

	private void Awake()
	{
	}

	public void SetInfo(ServantRuneSlot _info, clickBtn _action)
	{
	}

	private void SetRuneItemInfo(ObservableSingleRune _info)
	{
	}

	private void SetUI()
	{
	}
}
