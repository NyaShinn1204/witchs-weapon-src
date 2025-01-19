using System.Collections;
using System.Diagnostics;
using LuaFramework;
using LuaInterface;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LuaPanelBase : UIPanelBase
	{
		private string url;

		private Transform parent;

		private static LuaPanelBase instance;

		private LuaBehaviour luaBehaviour;

		public Transform Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static LuaPanelBase GetInstance()
		{
			return null;
		}

		public void Init()
		{
		}

		public virtual void CreatePanel(string name, LuaFunction luaFunc)
		{
		}

		[DebuggerHidden]
		private IEnumerator StartCreatePanel(string name, LuaFunction luaFunc)
		{
			return null;
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public virtual void ClosePanel(string pName)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
