using LuaInterface;
using UnityEngine;

namespace LuaFramework
{
	public class LuaManagerBase : MonoBehaviour
	{
		private LuaState lua;

		private LuaLooper loop;

		private LuaLoader loader;

		private string[] abs;

		public LuaState Lua
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LuaLooper Loop
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LuaLoader Loader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] Abs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void InitLua()
		{
		}

		private void InitCoreLua()
		{
		}

		private void InitLuaPath()
		{
		}

		private void InitLuaBundle()
		{
		}

		private void InitLuaLooper()
		{
		}

		private void InitLuaState()
		{
		}

		private void OpenLibs()
		{
		}

		public void Init()
		{
		}

		public virtual void Close()
		{
		}

		public virtual void LuaGC()
		{
		}

		public virtual object[] CallFunction(string funcName, params object[] args)
		{
			return null;
		}

		public virtual void CallFunction(string funcName)
		{
		}

		public virtual object[] DoFile(string name)
		{
			return null;
		}

		public virtual object[] DoString(string name)
		{
			return null;
		}

		public virtual bool DoLuaFile(string name)
		{
			return false;
		}

		public virtual bool DoLuaString(string name)
		{
			return false;
		}

		public LuaFunction GetLuaFunction(string funcName)
		{
			return null;
		}
	}
}
