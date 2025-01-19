using System;
using System.Collections.Generic;
using CLRSharp;
using UnityEngine;

namespace NewBattle
{
	public class ScriptInvokerComponent : MonoBehaviour
	{
		public const string SCRIPT_FUNC_START_NAME = "Start";

		public const string SCRIPT_FUNC_UPDATE_NAME = "Update";

		public string SCRIPT_NAMESPACE;

		public string DLL_NAME;

		public ScriptEngineContext context;

		public ICLRType wantType;

		public object scriptObject;

		public string className;

		protected bool isloaded;

		public string script;

		private object[] paramList;

		protected Dictionary<string, string> funcDic;

		public void LoadScript(string dll_name, string namespaceName, string scriptName, object[] paramList)
		{
		}

		protected void InitScriptContext()
		{
		}

		protected void InitScriptOnInitFunc()
		{
		}

		protected virtual void InitScriptFuncs()
		{
		}

		public virtual void Update()
		{
		}

		public void RunScriptMethod(string functionName, Type paramType = null, object paramValue = null)
		{
		}

		public void AddFunc(string name, string value = null)
		{
		}

		public void RemoveFunc(string name)
		{
		}

		public bool HasFunc(string funcName)
		{
			return false;
		}

		public string GetFuncName(string key)
		{
			return null;
		}

		public void OnDestory()
		{
		}

		public virtual void RemoveScriptFuncs()
		{
		}
	}
}
