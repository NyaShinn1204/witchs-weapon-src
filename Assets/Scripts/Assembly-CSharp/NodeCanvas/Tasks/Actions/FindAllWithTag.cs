using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class FindAllWithTag : ActionTask
	{
		[RequiredField]
		[TagField]
		public string searchTag;

		[BlackboardOnly]
		public BBParameter<List<GameObject>> saveAs;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}
	}
}
