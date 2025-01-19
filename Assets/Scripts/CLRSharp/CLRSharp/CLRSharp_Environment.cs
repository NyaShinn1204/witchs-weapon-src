using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Mono.Cecil.Cil;

namespace CLRSharp
{
	public class CLRSharp_Environment : ICLRSharp_Environment
	{
		private Dictionary<string, ICLRType> mapType;

		public List<Assembly> assemblylist;

		private List<string> moduleref;

		private Dictionary<Type, ICrossBind> crossBind;

		public string version
		{
			get
			{
				return null;
			}
		}

		public ICLRSharp_Logger logger { get; private set; }

		public CLRSharp_Environment(ICLRSharp_Logger logger)
		{
		}

		public void LoadModule(Stream dllStream, Stream pdbStream, ISymbolReaderProvider debugInfoLoader)
		{
		}

		public ICLRType GetType(string fullname)
		{
			return null;
		}

		public ICLRType GetType(Type systemType)
		{
			return null;
		}

		public void RegType(ICLRType type)
		{
		}

		public void RegCrossBind(ICrossBind bind)
		{
		}

		public ICrossBind GetCrossBind(Type type)
		{
			return null;
		}
	}
}
