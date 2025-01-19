using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Achievemod
{
	public sealed class Result : IMessage<Result>, IMessage, IEquatable<Result>, IDeepCloneable<Result>
	{
		private static readonly MessageParser<Result> _parser;

		public const int JobsFieldNumber = 1;

		private static readonly FieldCodec<Job> _repeated_jobs_codec;

		private readonly RepeatedField<Job> jobs_;

		public const int MetasFieldNumber = 2;

		private static readonly FieldCodec<MetaInfo> _repeated_metas_codec;

		private readonly RepeatedField<MetaInfo> metas_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Result> Parser
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
		public RepeatedField<Job> Jobs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<MetaInfo> Metas
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Result()
		{
		}

		[DebuggerNonUserCode]
		public Result(Result other)
		{
		}

		[DebuggerNonUserCode]
		public Result Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Result other)
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
		public void MergeFrom(Result other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
