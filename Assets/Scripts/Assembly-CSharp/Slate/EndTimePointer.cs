namespace Slate
{
	public struct EndTimePointer : IDirectableTimePointer
	{
		private bool triggered;

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

		public EndTimePointer(IDirectable target)
		{
			triggered = false;
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
