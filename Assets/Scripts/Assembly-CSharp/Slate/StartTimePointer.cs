namespace Slate
{
	public struct StartTimePointer : IDirectableTimePointer
	{
		private bool triggered;

		private float lastTargetStartTime;

		private IDirectable target;

		float IDirectableTimePointer.time
		{
			get
			{
				return 0f;
			}
		}

		private float targetLength
		{
			get
			{
				return 0f;
			}
		}

		public StartTimePointer(IDirectable target)
		{
			triggered = false;
			lastTargetStartTime = 0f;
			this.target = null;
		}

		void IDirectableTimePointer.TriggerForward(float currentTime, float previousTime)
		{
		}

		void IDirectableTimePointer.Update(float currentTime, float previousTime)
		{
		}

		void IDirectableTimePointer.TriggerBackward(float currentTime, float previousTime)
		{
		}
	}
}
