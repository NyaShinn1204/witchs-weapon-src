using System;

namespace WaterBell.ProjX.Data.Entity
{
	public class PropertyChangeedObservable
	{
		private bool isSubscribed;

		private P<PropertyChangeedObservable> self;

		public bool IsSubscribed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IDisposable Subscribe(Action<PropertyChangeedObservable> action)
		{
			return null;
		}

		public void SelfChange()
		{
		}
	}
}
