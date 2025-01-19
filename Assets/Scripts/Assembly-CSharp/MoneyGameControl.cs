using System;
using WaterBell.ProjX.View.Panel;

public class MoneyGameControl : UIPanelBase
{
	public class MoneyGameControlUIDataBase : UIDataBase
	{
		public string grade;

		public long propID;

		public int propCount;

		public MoneyGameControlUIDataBase(string sGrade, long sPropID = 40330110L, int sPropCount = 1)
		{
		}
	}

	private UIMoneyGame moneyGame;

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void DirectClosePanel()
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}
}
