using System.Collections.Generic;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace CLRSharp
{
	public class CodeBody
	{
		public class OpCode
		{
			public int addr;

			public CodeEx code;

			public int debugline;

			public object tokenUnknown;

			public int tokenAddr_Index;

			public int[] tokenAddr_Switch;

			public ICLRType tokenType;

			public IField tokenField;

			public IMethod tokenMethod;

			public int tokenI32;

			public long tokenI64;

			public float tokenR32;

			public double tokenR64;

			public string tokenStr;

			public override string ToString()
			{
				return null;
			}

			public void InitToken(ThreadContext context, CodeBody body, object _p)
			{
			}
		}

		public MethodParamList typelistForLoc;

		private MethodDefinition method;

		private bool bInited;

		public Dictionary<string, int> debugDoc;

		public List<OpCode> opCodes;

		public Dictionary<int, int> addr;

		public string doc;

		public MethodBody bodyNative
		{
			get
			{
				return null;
			}
		}

		public CodeBody(ICLRSharp_Environment env, MethodDefinition _def)
		{
		}

		public void Init(ICLRSharp_Environment env)
		{
		}
	}
}
