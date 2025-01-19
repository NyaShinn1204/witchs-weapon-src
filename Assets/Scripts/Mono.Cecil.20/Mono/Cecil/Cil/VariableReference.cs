namespace Mono.Cecil.Cil
{
	public abstract class VariableReference
	{
		private string name;

		internal int index;

		protected TypeReference variable_type;

		public string Name
		{
			set
			{
			}
		}

		public TypeReference VariableType
		{
			get
			{
				return null;
			}
		}

		public int Index
		{
			get
			{
				return 0;
			}
		}

		internal VariableReference(TypeReference variable_type)
		{
		}

		internal VariableReference(string name, TypeReference variable_type)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
