using System;
using System.Collections.Generic;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[SpoofAOT]
	public interface IBlackboard
	{
		string name { get; set; }

		Dictionary<string, Variable> variables { get; set; }

		GameObject propertiesBindTarget { get; }

		event Action<Variable> onVariableAdded;

		event Action<Variable> onVariableRemoved;

		Variable AddVariable(string varName, Type type);

		Variable AddVariable(string varName, object value);

		Variable RemoveVariable(string varName);

		Variable GetVariable(string varName, Type ofType = null);

		Variable GetVariableByID(string ID);

		Variable<T> GetVariable<T>(string varName);

		T GetValue<T>(string varName);

		Variable SetValue(string varName, object value);

		string[] GetVariableNames();

		string[] GetVariableNames(Type ofType);
	}
}
