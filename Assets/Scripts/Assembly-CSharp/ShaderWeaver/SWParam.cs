using System;

namespace ShaderWeaver
{
	[Serializable]
	public class SWParam
	{
		public SWParamType type;

		public string name;

		public float min;

		public float max;

		public float defaultValue;

		public SWParam()
		{
		}

		public SWParam(string _name)
		{
		}
	}
}
