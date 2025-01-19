using System;
using System.Collections.Generic;
using Mono.Cecil;

namespace CLRSharp
{
	public class Type_Common_CLRSharp : ICLRType_Sharp, ICLRType
	{
		public List<ICLRType> _Interfaces;

		private CLRSharp_Instance _staticInstance;

		private bool _isenum;

		public Type TypeForSystem
		{
			get
			{
				return null;
			}
		}

		public TypeDefinition type_CLRSharp { get; private set; }

		public ICLRSharp_Environment env { get; private set; }

		public ICLRType BaseType { get; private set; }

		public bool HasSysBase { get; private set; }

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string FullName
		{
			get
			{
				return null;
			}
		}

		public string FullNameWithAssembly
		{
			get
			{
				return null;
			}
		}

		public CLRSharp_Instance staticInstance
		{
			get
			{
				return null;
			}
		}

		public bool NeedCCtor { get; private set; }

		public bool ContainBase(Type t)
		{
			return false;
		}

		public string[] GetMethodNames()
		{
			return null;
		}

		public Type_Common_CLRSharp(ICLRSharp_Environment env, TypeDefinition type)
		{
		}

		public IMethod GetVMethod(IMethod _base)
		{
			return null;
		}

		public IMethod GetMethod(string funcname, MethodParamList types)
		{
			return null;
		}

		public object InitObj()
		{
			return null;
		}

		public IMethod GetMethodT(string funcname, MethodParamList ttypes, MethodParamList types)
		{
			return null;
		}

		public IField GetField(string name)
		{
			return null;
		}

		public bool IsInst(object obj)
		{
			return false;
		}

		public ICLRType GetNestType(ICLRSharp_Environment env, string fullname)
		{
			return null;
		}

		public void InvokeCCtor(ThreadContext context)
		{
		}

		public bool IsEnum()
		{
			return false;
		}
	}
}
