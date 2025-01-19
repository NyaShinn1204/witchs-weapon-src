using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class FileOptions : IMessage<FileOptions>, IMessage, IEquatable<FileOptions>, IDeepCloneable<FileOptions>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum OptimizeMode
			{
				Speed = 1,
				CodeSize = 2,
				LiteRuntime = 3
			}
		}

		private static readonly MessageParser<FileOptions> _parser;

		public const int JavaPackageFieldNumber = 1;

		private string javaPackage_;

		public const int JavaOuterClassnameFieldNumber = 8;

		private string javaOuterClassname_;

		public const int JavaMultipleFilesFieldNumber = 10;

		private bool javaMultipleFiles_;

		public const int JavaGenerateEqualsAndHashFieldNumber = 20;

		private bool javaGenerateEqualsAndHash_;

		public const int JavaStringCheckUtf8FieldNumber = 27;

		private bool javaStringCheckUtf8_;

		public const int OptimizeForFieldNumber = 9;

		private Types.OptimizeMode optimizeFor_;

		public const int GoPackageFieldNumber = 11;

		private string goPackage_;

		public const int CcGenericServicesFieldNumber = 16;

		private bool ccGenericServices_;

		public const int JavaGenericServicesFieldNumber = 17;

		private bool javaGenericServices_;

		public const int PyGenericServicesFieldNumber = 18;

		private bool pyGenericServices_;

		public const int DeprecatedFieldNumber = 23;

		private bool deprecated_;

		public const int CcEnableArenasFieldNumber = 31;

		private bool ccEnableArenas_;

		public const int ObjcClassPrefixFieldNumber = 36;

		private string objcClassPrefix_;

		public const int CsharpNamespaceFieldNumber = 37;

		private string csharpNamespace_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<FileOptions> Parser
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public string JavaPackage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string JavaOuterClassname
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool JavaMultipleFiles
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool JavaGenerateEqualsAndHash
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool JavaStringCheckUtf8
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Types.OptimizeMode OptimizeFor
		{
			get
			{
				return default(Types.OptimizeMode);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string GoPackage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool CcGenericServices
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool JavaGenericServices
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool PyGenericServices
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool Deprecated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool CcEnableArenas
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string ObjcClassPrefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string CsharpNamespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public FileOptions()
		{
		}

		[DebuggerNonUserCode]
		public FileOptions(FileOptions other)
		{
		}

		[DebuggerNonUserCode]
		public FileOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FileOptions other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(FileOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
