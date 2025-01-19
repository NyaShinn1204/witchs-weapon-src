using System.Collections;
using UnityEngine;

namespace AssemblyCSharp
{
	public class Battle : MonoBehaviour
	{
		private ArrayList _waves;

		private ArrayList _monstersAllNeed;

		private int _MaxEnemy;

		private int _currentWave;

		private int _MaxWave;

		private string _map;

		public TextAsset xmldata;

		public Battle(string map)
		{
		}

		public void generateWaveInfo()
		{
		}
	}
}
