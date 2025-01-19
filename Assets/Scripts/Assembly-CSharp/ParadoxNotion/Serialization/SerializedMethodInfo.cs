using System;
using System.Reflection;
using UnityEngine;

namespace ParadoxNotion.Serialization
{
	[Serializable]
	public class SerializedMethodInfo : ISerializationCallbackReceiver
	{
		[SerializeField]
		private string _returnInfo;

		[SerializeField]
		private string _baseInfo;

		[SerializeField]
		private string _paramsInfo;

		[NonSerialized]
		private MethodInfo _method;

		[NonSerialized]
		private bool _hasChanged;

		public SerializedMethodInfo()
		{
		}

		public SerializedMethodInfo(MethodInfo method)
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public MethodInfo Get()
		{
			return null;
		}

		public bool HasChanged()
		{
			return false;
		}

		public string GetMethodString()
		{
			return null;
		}
	}
}
