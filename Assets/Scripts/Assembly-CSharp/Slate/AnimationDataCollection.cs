using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Slate
{
	[Serializable]
	public class AnimationDataCollection : IAnimatableData
	{
		[SerializeField]
		private List<AnimatedParameter> _animatedParameters;

		public List<AnimatedParameter> animatedParameters
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool isValid
		{
			get
			{
				return false;
			}
		}

		public AnimatedParameter Item
		{
			get
			{
				return null;
			}
		}

		public AnimatedParameter Item
		{
			get
			{
				return null;
			}
		}

		public AnimationDataCollection()
		{
		}

		public AnimationDataCollection(MemberInfo[] memberInfoParameters, IKeyable keyable, Transform child, Transform root)
		{
		}

		public bool TryAddParameter(MemberInfo member, IKeyable keyable, Transform child, Transform root)
		{
			return false;
		}

		public AnimatedParameter GetParameterOfName(string name)
		{
			return null;
		}

		public AnimationCurve[] GetCurves()
		{
			return null;
		}

		public AnimationCurve[] GetCurvesAll()
		{
			return null;
		}

		private AnimationCurve[] Internal_GetCurves(bool enabledParamsOnly)
		{
			return null;
		}

		public void Validate(IKeyable keyable)
		{
		}

		public void SetVirtualTransformParent(Transform virtualTransformParent)
		{
		}

		public void SetSnapshot()
		{
		}

		public bool TryAutoKey(float time)
		{
			return false;
		}

		public void Evaluate(float time, float previousTime, float weight = 1f)
		{
		}

		public void RestoreSnapshot()
		{
		}

		public bool TryKeyIdentity(float time)
		{
			return false;
		}

		public void RemoveKey(float time)
		{
		}

		public bool HasChanged()
		{
			return false;
		}

		public bool HasKey(float time)
		{
			return false;
		}

		public bool HasAnyKey()
		{
			return false;
		}

		public void SetKeyCurrent(float time)
		{
		}

		public float GetKeyNext(float time)
		{
			return 0f;
		}

		public float GetKeyPrevious(float time)
		{
			return 0f;
		}

		public string GetKeyLabel(float time)
		{
			return null;
		}

		public void SetPreWrapMode(WrapMode mode)
		{
		}

		public void SetPostWrapMode(WrapMode mode)
		{
		}

		public void Reset()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
