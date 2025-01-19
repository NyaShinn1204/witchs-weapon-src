using System;

namespace ShaderWeaver
{
	[Serializable]
	public class CodeParam
	{
		public string name;

		public CodeParamType type;

		public float v;

		public float min;

		public float max;

		public CodeParam(string _name, CodeParamType _type)
		{
		}

		public CodeParam Clone()
		{
			return null;
		}

		public new SWDataType GetType()
		{
			return default(SWDataType);
		}

		public bool IsParam()
		{
			return false;
		}

		public bool IsProperty()
		{
			return false;
		}
	}
}
