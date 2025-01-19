using System;

namespace Google.Protobuf.Reflection
{
	public sealed class DescriptorValidationException : Exception
	{
		private readonly string name;

		private readonly string description;

		public string ProblemSymbolName
		{
			get
			{
				return null;
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
		}

		internal DescriptorValidationException(IDescriptor problemDescriptor, string description)
		{
		}

		internal DescriptorValidationException(IDescriptor problemDescriptor, string description, Exception cause)
		{
		}
	}
}
