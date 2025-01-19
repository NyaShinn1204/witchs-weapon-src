using System;
using System.Reflection;

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsConfig
	{
		public Type[] SerializeAttributes;

		public Type[] IgnoreSerializeAttributes;

		public fsMemberSerialization DefaultMemberSerialization;

		public Func<string, MemberInfo, string> GetJsonNameFromMemberName;

		public bool SerializeNonAutoProperties;

		public bool SerializeNonPublicSetProperties;

		public string CustomDateTimeFormatString;

		public bool Serialize64BitIntegerAsString;

		public bool SerializeEnumsAsInteger;
	}
}
