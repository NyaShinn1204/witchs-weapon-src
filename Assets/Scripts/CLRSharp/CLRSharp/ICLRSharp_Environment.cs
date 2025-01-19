using System;

namespace CLRSharp
{
	public interface ICLRSharp_Environment
	{
		ICLRSharp_Logger logger { get; }

		ICLRType GetType(string name);

		ICLRType GetType(Type systemType);

		void RegType(ICLRType type);

		ICrossBind GetCrossBind(Type type);
	}
}
