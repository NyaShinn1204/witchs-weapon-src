using UnityEngine;
using WaterBell.ProjX.Guide.DataModel;

namespace WaterBell.ProjX.Guide.Content
{
	public class StoryRoleD : MonoBehaviour
	{
		private UISprite faceSprite;

		private UITexture bodyTex;

		private Transform selfTrans;

		private int depth;

		private string _name;

		private string _sn;

		public string sn
		{
			get
			{
				return null;
			}
		}

		public string roleName
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void BindRoleData(ConversationRole roleData)
		{
		}

		public void SetFace(string faceName)
		{
		}

		public void SetDepth(int baseDepth)
		{
		}

		public void Remove()
		{
		}
	}
}
