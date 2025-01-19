using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Slate
{
	public abstract class ActionClip : MonoBehaviour, IDirectable, IKeyable
	{
		[SerializeField]
		[HideInInspector]
		private float _startTime;

		[SerializeField]
		[HideInInspector]
		private AnimationDataCollection _animationData;

		private MemberInfo[] _cachedParamsInfo;

		IEnumerable<IDirectable> IDirectable.children
		{
			get
			{
				return null;
			}
		}

		public IDirector root
		{
			get
			{
				return null;
			}
		}

		public IDirectable parent { get; private set; }

		public GameObject actor
		{
			get
			{
				return null;
			}
		}

		public AnimationDataCollection animationData
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public float startTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float endTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isActive
		{
			get
			{
				return false;
			}
		}

		public bool isCollapsed
		{
			get
			{
				return false;
			}
		}

		public bool isLocked
		{
			get
			{
				return false;
			}
		}

		public virtual float length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float blendIn
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float blendOut
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual string info
		{
			get
			{
				return null;
			}
		}

		public virtual bool isValid
		{
			get
			{
				return false;
			}
		}

		public virtual TransformSpace defaultTransformSpace
		{
			get
			{
				return default(TransformSpace);
			}
		}

		private MemberInfo[] animatedParametersInfo
		{
			get
			{
				return null;
			}
		}

		private bool handleParametersRegistrationManually
		{
			get
			{
				return false;
			}
		}

		public virtual object animatedParametersTarget
		{
			get
			{
				return null;
			}
		}

		public virtual bool useWeightInParameters
		{
			get
			{
				return false;
			}
		}

		public bool hasParameters
		{
			get
			{
				return false;
			}
		}

		public bool hasActiveParameters
		{
			get
			{
				return false;
			}
		}

		bool IDirectable.Initialize()
		{
			return false;
		}

		void IDirectable.Enter()
		{
		}

		void IDirectable.Update(float time, float previousTime)
		{
		}

		void IDirectable.Exit()
		{
		}

		void IDirectable.ReverseEnter()
		{
		}

		void IDirectable.Reverse()
		{
		}

		void IDirectable.RootEnabled()
		{
		}

		void IDirectable.RootDisabled()
		{
		}

		void IDirectable.RootUpdated(float time, float previousTime)
		{
		}

		protected virtual bool OnInitialize()
		{
			return false;
		}

		protected virtual void OnEnter()
		{
		}

		protected virtual void OnUpdate(float time, float previousTime)
		{
		}

		protected virtual void OnUpdate(float time)
		{
		}

		protected virtual void OnExit()
		{
		}

		protected virtual void OnReverse()
		{
		}

		protected virtual void OnReverseEnter()
		{
		}

		protected virtual void OnDrawGizmosSelected()
		{
		}

		protected virtual void OnSceneGUI()
		{
		}

		protected virtual void OnCreate()
		{
		}

		protected virtual void OnAfterValidate()
		{
		}

		protected virtual void OnRootEnabled()
		{
		}

		protected virtual void OnRootDisabled()
		{
		}

		protected virtual void OnRootUpdated(float time, float previousTime)
		{
		}

		public void PostCreate(IDirectable parent)
		{
		}

		public void Validate()
		{
		}

		public void Validate(IDirector root, IDirectable parent)
		{
		}

		public bool RootTimeWithinRange()
		{
			return false;
		}

		public Vector3 TransformPoint(Vector3 point, TransformSpace space)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformPoint(Vector3 point, TransformSpace space)
		{
			return default(Vector3);
		}

		public Vector3 ActorPositionInSpace(TransformSpace space)
		{
			return default(Vector3);
		}

		public Transform GetSpaceTransform(TransformSpace space)
		{
			return null;
		}

		public ActionClip GetPreviousClip()
		{
			return null;
		}

		public ActionClip GetNextClip()
		{
			return null;
		}

		public float GetClipWeight()
		{
			return 0f;
		}

		public float GetClipWeight(float time)
		{
			return 0f;
		}

		public float GetClipWeight(float time, float blendInOut)
		{
			return 0f;
		}

		public float GetClipWeight(float time, float blendIn, float blendOut)
		{
			return 0f;
		}

		public AnimatedParameter GetParameter(string paramName)
		{
			return null;
		}

		public void SetParameterEnabled(string paramName, bool enabled)
		{
		}

		public void ResetAnimatedParameters()
		{
		}

		private void CreateAnimationDataCollection()
		{
		}

		private void ValidateAnimParams()
		{
		}

		private void SetAnimParamsSnapshot()
		{
		}

		private void UpdateAnimParams(float time, float previousTime)
		{
		}

		private void RestoreAnimParamsSnapshot()
		{
		}

		string IDirectable.get_name()
		{
			return null;
		}
	}
}
