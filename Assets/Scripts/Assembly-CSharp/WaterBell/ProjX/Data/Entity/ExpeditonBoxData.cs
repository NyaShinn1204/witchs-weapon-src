using UnityEngine;

namespace WaterBell.ProjX.Data.Entity
{
	public class ExpeditonBoxData
	{
		public GameObject go;

		public string ServantId;

		public string GoName;

		public int hp;

		public float energy;

		public ExpeditonBoxData(GameObject _go)
		{
		}

		public ExpeditonBoxData(GameObject _go, string _id, int _hp)
		{
		}

		public ExpeditonBoxData(GameObject _go, string _id, string _name, int _hp, float _energy)
		{
		}
	}
}
