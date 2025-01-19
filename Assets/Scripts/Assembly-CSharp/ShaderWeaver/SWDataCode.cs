using System;
using System.Collections.Generic;

namespace ShaderWeaver
{
	[Serializable]
	public class SWDataCode
	{
		public string name;

		public string description;

		public CodeParam output;

		public List<CodeParam> inputs;

		public string code;

		public SWDataCode(string _name, CodeParamType _outType)
		{
		}

		public SWDataCode Clone(string newName)
		{
			return null;
		}

		public List<CodeParam> RealInputs()
		{
			return null;
		}

		public void AddParam()
		{
		}

		public string NextParam()
		{
			return null;
		}

		public bool ContainParam(string name)
		{
			return false;
		}

		public CodeParam GetParam(string name)
		{
			return null;
		}

		public bool IsFunction()
		{
			return false;
		}
	}
}
