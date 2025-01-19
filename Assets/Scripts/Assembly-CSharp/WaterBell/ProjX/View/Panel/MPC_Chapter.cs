using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class MPC_Chapter : UIPanelSingle
	{
		public MPC_LevelPos[] levelPosArr;

		public MPC_RoadKeyPoint[] roadKeyPoints;

		public Transform camPos;

		private Transform road;

		private Transform levelIcon;

		private Dictionary<int, MPC_Road> roadDict;

		private Dictionary<int, List<Transform>> roadKeyDict;

		private MPC_LevelPos challengePos;

		private List<MPC_LevelIcon> levelIconList;

		protected override void Awake()
		{
		}

		public void Init()
		{
		}

		private void CreateLevelIcon()
		{
		}

		private void LoadModel()
		{
		}

		public void UpdateRoad()
		{
		}
	}
}
