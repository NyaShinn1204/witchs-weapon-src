using System;
using System.Reflection;
using UnityEngine;

namespace Slate
{
	[Serializable]
	public class AnimatedParameter : IAnimatableData
	{
		[Serializable]
		private class SerializationMetaData
		{
			public bool enabled;

			public string parameterName;

			public string declaringTypeName;

			public string transformHierarchyPath;

			public ParameterType parameterType;

			public Type declaringType { get; private set; }

			public PropertyInfo property { get; private set; }

			public FieldInfo field { get; private set; }

			public Type animatedType { get; private set; }

			public void Deserialize()
			{
			}
		}

		public enum ParameterType
		{
			NotSet = 0,
			Property = 1,
			Field = 2
		}

		private const float COMPARE_THRESHOLD = 0.001f;

		private const float PROXIMITY_TOLERANCE = 1f / 30f;

		[SerializeField]
		private string _serializedData;

		[SerializeField]
		private AnimationCurve[] _curves;

		[SerializeField]
		private string _scriptExpression;

		[NonSerialized]
		private SerializationMetaData _data;

		public static readonly Type[] supportedTypes;

		[NonSerialized]
		private object _animatableAttribute;

		[NonSerialized]
		private object _resolved;

		[NonSerialized]
		private Action<bool> setterBool;

		[NonSerialized]
		private Action<int> setterInt;

		[NonSerialized]
		private Action<float> setterFloat;

		[NonSerialized]
		private Action<Vector2> setterVector2;

		[NonSerialized]
		private Action<Vector3> setterVector3;

		[NonSerialized]
		private Action<Color> setterColor;

		[NonSerialized]
		private object lastResolvedObject;

		public bool enabled
		{
			get
			{
				return false;
			}
		}

		private string serializedData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private SerializationMetaData data
		{
			get
			{
				return null;
			}
		}

		public AnimationCurve[] curves
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string scriptExpression
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string parameterName
		{
			get
			{
				return null;
			}
		}

		public Type animatedType
		{
			get
			{
				return null;
			}
		}

		public ParameterType parameterType
		{
			get
			{
				return default(ParameterType);
			}
		}

		public string transformHierarchyPath
		{
			get
			{
				return null;
			}
		}

		public Type declaringType
		{
			get
			{
				return null;
			}
		}

		public PropertyInfo property
		{
			get
			{
				return null;
			}
		}

		public FieldInfo field
		{
			get
			{
				return null;
			}
		}

		public bool isProperty
		{
			get
			{
				return false;
			}
		}

		public IKeyable keyable { get; private set; }

		public object snapshot { get; private set; }

		public object currentEval { get; private set; }

		public Transform virtualTransformParent { get; private set; }

		public object targetObject
		{
			get
			{
				return null;
			}
		}

		public AnimatableParameterAttribute animatableAttribute
		{
			get
			{
				return null;
			}
		}

		public bool isExternal
		{
			get
			{
				return false;
			}
		}

		private AnimationCurve curve1
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private AnimationCurve curve2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private AnimationCurve curve3
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private AnimationCurve curve4
		{
			get
			{
				return null;
			}
			set
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

		public static event Action<IAnimatableData> onParameterChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public AnimatedParameter(MemberInfo member, IKeyable keyable, Transform child, Transform root)
		{
		}

		public void SetEnabled(bool value, float time)
		{
		}

		public MemberInfo GetMemberInfo()
		{
			return null;
		}

		public AnimationCurve[] GetCurves()
		{
			return null;
		}

		private void ConstructWithProperty(PropertyInfo targetProperty, Transform child, Transform root)
		{
		}

		private void ConstructWithField(FieldInfo targetField, Transform child, Transform root)
		{
		}

		public bool CompareTo(AnimatedParameter animParam)
		{
			return false;
		}

		private string CalculateTransformPath(Transform root, Transform child)
		{
			return null;
		}

		private Transform ResolveTransformPath(Transform root)
		{
			return null;
		}

		private void InitializeCurves()
		{
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

		public object ResolvedObject()
		{
			return null;
		}

		public object GetCurrentValue()
		{
			return null;
		}

		public void SetCurrentValue(object value)
		{
		}

		public object GetEvalValue(float time)
		{
			return null;
		}

		private void Internal_Evaluate_Runtime(float time, float previousTime, float weight = 1f)
		{
		}

		public bool TryKeyIdentity(float time)
		{
			return false;
		}

		public bool HasChanged()
		{
			return false;
		}

		public void SetKeyCurrent(float time)
		{
		}

		private void SetKey(float time, object value)
		{
		}

		private bool AddKey(AnimationCurve curve, float time, float value)
		{
			return false;
		}

		public void RemoveKey(float time)
		{
		}

		public void SetPreWrapMode(WrapMode mode)
		{
		}

		public void SetPostWrapMode(WrapMode mode)
		{
		}

		public bool HasAnyKey()
		{
			return false;
		}

		public bool HasKey(float time)
		{
			return false;
		}

		public float GetKeyNext(float time)
		{
			return 0f;
		}

		public float GetKeyPrevious(float time)
		{
			return 0f;
		}

		public void OffsetValue(object deltaValue)
		{
		}

		private void OffsetCurveValues(AnimationCurve curve, float deltaValue)
		{
		}

		public void Reset()
		{
		}

		public void ChangeMemberType(ParameterType newType)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string GetKeyLabel(float time)
		{
			return null;
		}

		private void RecordUndo()
		{
		}

		private void NotifyChange()
		{
		}
	}
}
