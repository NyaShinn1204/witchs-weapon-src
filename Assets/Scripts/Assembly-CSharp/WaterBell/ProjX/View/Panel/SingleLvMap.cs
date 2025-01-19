using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class SingleLvMap : MonoBehaviour
	{
		public bool isDebugAndIgnoreProgress;

		private LevelMapLvIcon[] BigLVIcons;

		private LevelMapLvIcon[] SmallLVIcons;

		private LevelMapLvIcon[] TestLVIcons;

		private GameObject[] BigAnchors;

		private GameObject[] SmallAnchors;

		private Dictionary<string, int> normalLevelDic;

		private Dictionary<string, int> eliteLevelDic;

		private GameObject Arrow;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void InitSingleMap(MonoBehaviour target)
		{
		}

		public void SwitchToNormal()
		{
		}

		public void SwitchToElite()
		{
		}
	}
}
