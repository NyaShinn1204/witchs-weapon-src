using System;
using UnityEngine;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class BBObjectParameter : BBParameter<object>
	{
		[SerializeField]
		private Type _type;

		public override Type varType
		{
			get
			{
				return null;
			}
		}

		public BBObjectParameter()
		{
		}

		public BBObjectParameter(Type t)
		{
		}

		public void SetType(Type t)
		{
		}
	}
}
