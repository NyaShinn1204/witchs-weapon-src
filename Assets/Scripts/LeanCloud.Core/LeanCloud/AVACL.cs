using System.Collections.Generic;
using LeanCloud.Storage.Internal;

namespace LeanCloud
{
	public class AVACL : IJsonConvertible
	{
		private enum AccessKind
		{
			Read = 0,
			Write = 1
		}

		private const string publicName = "*";

		private readonly ICollection<string> readers;

		private readonly ICollection<string> writers;

		public bool PublicReadAccess
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool PublicWriteAccess
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal AVACL(IDictionary<string, object> jsonObject)
		{
		}

		public AVACL()
		{
		}

		public AVACL(AVUser owner)
		{
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}

		private void SetAccess(AccessKind kind, string userId, bool allowed)
		{
		}

		private bool GetAccess(AccessKind kind, string userId)
		{
			return false;
		}

		public void SetReadAccess(string userId, bool allowed)
		{
		}

		public void SetReadAccess(AVUser user, bool allowed)
		{
		}

		public void SetWriteAccess(string userId, bool allowed)
		{
		}

		public void SetWriteAccess(AVUser user, bool allowed)
		{
		}

		public bool GetReadAccess(string userId)
		{
			return false;
		}

		public bool GetReadAccess(AVUser user)
		{
			return false;
		}

		public bool GetWriteAccess(string userId)
		{
			return false;
		}

		public bool GetWriteAccess(AVUser user)
		{
			return false;
		}

		public void SetRoleReadAccess(string roleName, bool allowed)
		{
		}

		public void SetRoleReadAccess(AVRole role, bool allowed)
		{
		}

		public bool GetRoleReadAccess(string roleName)
		{
			return false;
		}

		public bool GetRoleReadAccess(AVRole role)
		{
			return false;
		}

		public void SetRoleWriteAccess(string roleName, bool allowed)
		{
		}

		public void SetRoleWriteAccess(AVRole role, bool allowed)
		{
		}

		public bool GetRoleWriteAccess(string roleName)
		{
			return false;
		}

		public bool GetRoleWriteAccess(AVRole role)
		{
			return false;
		}
	}
}
