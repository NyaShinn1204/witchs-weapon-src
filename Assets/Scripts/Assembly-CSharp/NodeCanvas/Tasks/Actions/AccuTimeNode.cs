using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class AccuTimeNode : ActionTask
	{
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

		public int value2Index;

		public string tableArgName2;

		[SerializeField]
		public string veriable;

		private ValueParam param1;

		private ValueParam param2;

		private int maxTime;

		private float currentTime;

		private float floatVar;

		private Entity entity;

		protected override string OnInit()
		{
			return null;
		}

		private void GetMax()
		{
		}

		protected override void OnUpdate()
		{
		}
	}
}
