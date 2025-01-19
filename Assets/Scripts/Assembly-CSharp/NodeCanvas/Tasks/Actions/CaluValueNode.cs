using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class CaluValueNode : ActionTask
	{
		public enum CaluType
		{
			TYPE_ADD = 1,
			TYPE_MINUS = 2,
			TYPE_MUTIPLY = 3,
			TYPE_DEVIDE = 4
		}

		public CaluType conditionType;

		public ValueParam.Type value1Opra;

		public float value1;

		[SerializeField]
		public BBParameter<float> blackBoardAtrr1;

		public int target1type;

		public float target1Argu1;

		public float target1Argu2;

		public float target1Argu3;

		public float target1Argu4;

		public float target1Argu5;

		public int value1Index;

		public string tableArgName1;

		public ValueParam.Type value2Opra;

		public float value2;

		[SerializeField]
		public BBParameter<float> blackBoardAtrr2;

		public int target2type;

		public float target2Argu1;

		public float target2Argu2;

		public float target2Argu3;

		public float target2Argu4;

		public float target2Argu5;

		public string tableArgName2;

		public int value2Index;

		[SerializeField]
		public string targetBackgroundField;

		private Entity entity;

		private ValueParam param1;

		private ValueParam param2;

		protected override void OnExecute()
		{
		}

		private float Calu(CaluType type, float value1, float value2)
		{
			return 0f;
		}
	}
}
