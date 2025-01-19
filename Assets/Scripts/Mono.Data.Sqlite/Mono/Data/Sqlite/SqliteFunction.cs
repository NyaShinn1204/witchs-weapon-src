using System;
using System.Collections.Generic;

namespace Mono.Data.Sqlite
{
	public abstract class SqliteFunction : IDisposable
	{
		private class AggregateData
		{
			internal int _count;

			internal object _data;
		}

		internal SQLiteBase _base;

		private Dictionary<long, AggregateData> _contextDataList;

		private SQLiteCallback _InvokeFunc;

		private SQLiteCallback _StepFunc;

		private SQLiteFinalCallback _FinalFunc;

		private SQLiteCollation _CompareFunc;

		private SQLiteCollation _CompareFunc16;

		internal IntPtr _context;

		private static List<SqliteFunctionAttribute> _registeredFunctions;

		static SqliteFunction()
		{
		}

		public virtual object Invoke(object[] args)
		{
			return null;
		}

		public virtual void Step(object[] args, int stepNumber, ref object contextData)
		{
		}

		public virtual object Final(object contextData)
		{
			return null;
		}

		public virtual int Compare(string param1, string param2)
		{
			return 0;
		}

		internal object[] ConvertParams(int nArgs, IntPtr argsptr)
		{
			return null;
		}

		private void SetReturnValue(IntPtr context, object returnValue)
		{
		}

		internal void ScalarCallback(IntPtr context, int nArgs, IntPtr argsptr)
		{
		}

		internal int CompareCallback(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2)
		{
			return 0;
		}

		internal int CompareCallback16(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2)
		{
			return 0;
		}

		internal void StepCallback(IntPtr context, int nArgs, IntPtr argsptr)
		{
		}

		internal void FinalCallback(IntPtr context)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}

		internal static SqliteFunction[] BindFunctions(SQLiteBase sqlbase)
		{
			return null;
		}
	}
}
