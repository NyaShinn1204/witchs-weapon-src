using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	[ExecuteInEditMode]
	public class MPC_LevelPos : MonoBehaviour
	{
		public enum LevelPosTypes
		{
			General = 0,
			Challenge = 1
		}

		public LevelPosTypes levelPosType;

		public Vector2 iconOffset;

		public bool isShowIcon;
	}
}
