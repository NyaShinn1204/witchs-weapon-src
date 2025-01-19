using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.Level
{
	public class MapManager : MonoBehaviour
	{
		public static MapManager instance;

		public GameObject ground;

		public bool isAutoLinking;

		private Rect rect;

		private MapData currMapData;

		private List<MapData> mdList;

		public float WIDTH
		{
			get
			{
				return 0f;
			}
		}

		public float HEIGHT
		{
			get
			{
				return 0f;
			}
		}

		private void Awake()
		{
		}

		public void OnLoadIn()
		{
		}

		public void OnRestart()
		{
		}

		private void LoadFirstChildAsInitMap()
		{
		}

		public void ActiveCurrMapAStart()
		{
		}

		public Vector3 globalToLocal(Vector3 pos)
		{
			return default(Vector3);
		}

		public Vector3 localToGlobal(Vector3 pos)
		{
			return default(Vector3);
		}
	}
}
