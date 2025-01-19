using System;
using System.Collections.Generic;

namespace WaterBell.ProjX.View.Panel
{
	[Serializable]
	public class ConstellationDiagram
	{
		public long id;

		public string name;

		public List<ConstellationDiagramConnect> connectList;

		public static long GetConstellationDiagram(List<Star> starList)
		{
			return 0L;
		}

		public static void CreatRandomConstellationDiagram(List<Star> starList, int connectCount)
		{
		}

		public static void SetStars(ConstellationDiagram constellationDiagram)
		{
		}
	}
}
