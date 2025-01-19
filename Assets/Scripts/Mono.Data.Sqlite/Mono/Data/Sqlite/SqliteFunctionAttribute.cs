using System;

namespace Mono.Data.Sqlite
{
	public sealed class SqliteFunctionAttribute : Attribute
	{
		private string _name;

		private int _arguments;

		private FunctionType _functionType;

		internal Type _instanceType;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public int Arguments
		{
			get
			{
				return 0;
			}
		}

		public FunctionType FuncType
		{
			get
			{
				return default(FunctionType);
			}
		}
	}
}
