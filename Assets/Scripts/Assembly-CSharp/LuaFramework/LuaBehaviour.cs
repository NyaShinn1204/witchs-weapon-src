using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace LuaFramework
{
	public class LuaBehaviour : MonoBehaviour
	{
		private string data;

		private AssetBundle bundle;

		private Dictionary<string, LuaFunction> buttons;

		protected void Awake()
		{
		}

		protected void Start()
		{
		}

		protected void OnClick()
		{
		}

		protected void OnClickEvent(GameObject go)
		{
		}

		public void OnInit(AssetBundle bundle, string text = null)
		{
		}

		public GameObject LoadAsset(string name)
		{
			return null;
		}

		public void AddClick(GameObject go, LuaFunction luafunc)
		{
		}

		public void RemoveClick(GameObject go)
		{
		}

		public void ClearClick()
		{
		}

		protected void OnDestroy()
		{
		}
	}
}
