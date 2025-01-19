using System.Text.RegularExpressions;

namespace LeanCloud
{
	public class AVRole : AVObject
	{
		private static readonly Regex namePattern;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AVRelation<AVUser> Users
		{
			get
			{
				return null;
			}
		}

		public AVRelation<AVRole> Roles
		{
			get
			{
				return null;
			}
		}

		public static AVQuery<AVRole> Query
		{
			get
			{
				return null;
			}
		}

		public AVRole()
		{
		}

		public AVRole(string name, AVACL acl)
		{
		}

		internal override void OnSettingValue(ref string key, ref object value)
		{
		}
	}
}
