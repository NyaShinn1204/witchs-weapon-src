namespace WaterBell.ProjX.View.Panel
{
	public class UnlockNotificationPanelData : UIDataBase
	{
		public enum EffectColor
		{
			Yellow = 0,
			Blue = 1,
			Purple = 2
		}

		public string context;

		public EffectColor effectColor;

		public UnlockNotificationPanelData(string context, EffectColor effectColor)
		{
		}
	}
}
