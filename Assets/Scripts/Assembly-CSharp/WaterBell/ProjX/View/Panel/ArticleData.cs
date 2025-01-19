using System;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class ArticleData : UIDataBase
	{
		public string bg;

		public string name;

		public string quality;

		public string other;

		public string icon;

		public int count;

		public ArticleData(long id, string bg, string quality, string other, string icon, int count, string name)
		{
		}

		public ArticleData(long id)
		{
		}

		public ArticleData(long id, int count)
		{
		}
	}
}
