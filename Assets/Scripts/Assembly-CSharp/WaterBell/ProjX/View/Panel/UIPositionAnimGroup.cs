namespace WaterBell.ProjX.View.Panel
{
	public class UIPositionAnimGroup : UIAnimGroup<TweenPosition>
	{
		public enum Arrangement
		{
			Horizontal = 0,
			Vertical = 1
		}

		public float from;

		public float to;

		public Arrangement arrangement;

		protected override void ChildInit(TweenPosition t)
		{
		}
	}
}
