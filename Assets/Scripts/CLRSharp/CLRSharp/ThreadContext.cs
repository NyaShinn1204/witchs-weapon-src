using System;
using System.Collections.Generic;

namespace CLRSharp
{
	public class ThreadContext
	{
		[ThreadStatic]
		private static ThreadContext _activeContext;

		private Stack<StackFrame> stacks;

		public bool SetNoTry;

		private Dictionary<int, IMethod> methodCache;

		private Dictionary<int, IField> fieldCache;

		public static ThreadContext activeContext
		{
			get
			{
				return null;
			}
		}

		public ICLRSharp_Environment environment { get; private set; }

		public int DebugLevel { get; private set; }

		public ThreadContext(ICLRSharp_Environment env)
		{
		}

		public Stack<StackFrame> GetStackFrames()
		{
			return null;
		}

		public string Dump()
		{
			return null;
		}

		public object ExecuteFunc(IMethod_Sharp method, object _this, object[] _params)
		{
			return null;
		}

		private void RunCodeWithTry(CodeBody body, StackFrame stack)
		{
		}

		public ICLRType GetType(string fullname)
		{
			return null;
		}

		public ICLRType GetType(object token)
		{
			return null;
		}

		public IMethod GetMethod(object token)
		{
			return null;
		}

		public IField GetField(object token)
		{
			return null;
		}

		private object GetToken(object token)
		{
			return null;
		}

		private int GetBaseCount(Type _now, Type _base)
		{
			return 0;
		}

		private bool JumpToErr(CodeBody body, StackFrame frame, Exception err)
		{
			return false;
		}

		private void RunCode(StackFrame stack, CodeBody body)
		{
		}
	}
}
