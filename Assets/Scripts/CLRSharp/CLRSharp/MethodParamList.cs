using System;
using System.Collections.Generic;
using System.Reflection;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;

namespace CLRSharp
{
	public class MethodParamList : List<ICLRType>
	{
		private static MethodParamList _OneParam_Int;

		private static MethodParamList _ZeroParam;

		private string name;

		private Type[] SystemType;

		private MethodParamList(IList<ICLRType> types)
		{
		}

		public static MethodParamList constEmpty()
		{
			return null;
		}

		public static MethodParamList Make(params ICLRType[] types)
		{
			return null;
		}

		public MethodParamList(ICLRSharp_Environment env, MethodReference method)
		{
		}

		public MethodParamList(ICLRSharp_Environment env, Collection<VariableDefinition> ps)
		{
		}

		public MethodParamList(ICLRSharp_Environment env, GenericInstanceMethod method)
		{
		}

		public MethodParamList(ICLRSharp_Environment env, MethodBase method)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public Type[] ToArraySystem()
		{
			return null;
		}
	}
}
