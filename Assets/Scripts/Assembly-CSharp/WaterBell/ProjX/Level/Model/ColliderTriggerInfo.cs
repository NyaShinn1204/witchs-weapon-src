namespace WaterBell.ProjX.Level.Model
{
	public class ColliderTriggerInfo
	{
		public bool allowSkillPenetration { get; set; }

		public bool triggerCameraFocusOnFirstMob { get; set; }

		public double triggerCameraAnimationDurationInSec { get; set; }

		public string name { get; set; }

		public string opName { get; set; }

		public double[] PRS { get; set; }
	}
}
