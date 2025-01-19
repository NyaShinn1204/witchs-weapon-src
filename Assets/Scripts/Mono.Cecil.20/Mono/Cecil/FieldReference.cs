namespace Mono.Cecil
{
	public class FieldReference : MemberReference
	{
		private TypeReference field_type;

		public TypeReference FieldType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string FullName
		{
			get
			{
				return null;
			}
		}

		internal override bool ContainsGenericParameter
		{
			get
			{
				return false;
			}
		}

		internal FieldReference()
		{
		}

		public FieldReference(string name, TypeReference fieldType)
		{
		}
	}
}
