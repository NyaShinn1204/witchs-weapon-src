using System;
using Mono.Cecil;

namespace CLRSharp
{
	public interface ICLRType_Sharp : ICLRType
	{
		CLRSharp_Instance staticInstance { get; }

		bool NeedCCtor { get; }

		TypeDefinition type_CLRSharp { get; }

		bool HasSysBase { get; }

		void InvokeCCtor(ThreadContext context);

		IMethod GetVMethod(IMethod _base);

		bool ContainBase(Type t);

		string[] GetMethodNames();
	}
}
