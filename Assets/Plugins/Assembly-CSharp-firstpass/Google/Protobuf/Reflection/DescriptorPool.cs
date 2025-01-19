using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Google.Protobuf.Reflection
{
	internal sealed class DescriptorPool
	{
		private struct DescriptorIntPair : IEquatable<DescriptorIntPair>
		{
			private readonly int number;

			private readonly IDescriptor descriptor;

			internal DescriptorIntPair(IDescriptor descriptor, int number)
			{
				this.number = 0;
				this.descriptor = null;
			}

			public bool Equals(DescriptorIntPair other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		private readonly IDictionary<string, IDescriptor> descriptorsByName;

		private readonly IDictionary<DescriptorIntPair, FieldDescriptor> fieldsByNumber;

		private readonly IDictionary<DescriptorIntPair, EnumValueDescriptor> enumValuesByNumber;

		private readonly HashSet<FileDescriptor> dependencies;

		private static readonly Regex ValidationRegex;

		internal DescriptorPool(FileDescriptor[] dependencyFiles)
		{
		}

		private void ImportPublicDependencies(FileDescriptor file)
		{
		}

		internal T FindSymbol<T>(string fullName) where T : class
		{
			return null;
		}

		internal void AddPackage(string fullName, FileDescriptor file)
		{
		}

		internal void AddSymbol(IDescriptor descriptor)
		{
		}

		private static void ValidateSymbolName(IDescriptor descriptor)
		{
		}

		internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number)
		{
			return null;
		}

		internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number)
		{
			return null;
		}

		internal void AddFieldByNumber(FieldDescriptor field)
		{
		}

		internal void AddEnumValueByNumber(EnumValueDescriptor enumValue)
		{
		}

		internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo)
		{
			return null;
		}
	}
}
