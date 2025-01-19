using Mono.Collections.Generic;

namespace Mono.Cecil
{
	public sealed class ArrayType : TypeSpecification
	{
		private Collection<ArrayDimension> dimensions;

		public Collection<ArrayDimension> Dimensions
		{
			get
			{
				return null;
			}
		}

		public bool IsVector
		{
			get
			{
				return false;
			}
		}

		public override bool IsValueType
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string Name
		{
			get
			{
				return null;
			}
		}

		public override string FullName
		{
			get
			{
				return null;
			}
		}

		private string Suffix
		{
			get
			{
				return null;
			}
		}

		public override bool IsArray
		{
			get
			{
				return false;
			}
		}

		public ArrayType(TypeReference type)
			: base(null)
		{
		}
	}
}
