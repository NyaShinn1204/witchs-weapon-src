using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class DebugLogText : ActionTask<Transform>
	{
		public enum LogMode
		{
			Log = 0,
			Warning = 1,
			Error = 2
		}

		[RequiredField]
		public BBParameter<string> log;

		public float labelYOffset;

		public float secondsToRun;

		public LogMode logMode;

		public CompactStatus finishStatus;

		private Texture2D _tex;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		private Texture2D tex
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		protected override void OnStop()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void OnGUI()
		{
		}
	}
}
