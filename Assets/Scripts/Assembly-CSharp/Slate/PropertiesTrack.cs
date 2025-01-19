using UnityEngine;

namespace Slate
{
	[UniqueElement]
	public abstract class PropertiesTrack : CutsceneTrack, IKeyable, IDirectable
	{
		[SerializeField]
		[HideInInspector]
		private AnimationDataCollection _animationData;

		public AnimationDataCollection animationData
		{
			get
			{
				return null;
			}
		}

		public object animatedParametersTarget
		{
			get
			{
				return null;
			}
		}

		protected override void OnAfterValidate()
		{
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float time, float previousTime)
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
