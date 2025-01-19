using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Facebook.Unity
{
	internal class GraphResult : ResultBase, IGraphResult, IResult
	{
		[CompilerGenerated]
		private IList<object> _003CResultList_003Ek__BackingField;

		private IList<object> ResultList
		{
			[CompilerGenerated]
			set
			{
				_003CResultList_003Ek__BackingField = value;
			}
		}

		public Texture2D Texture { get; private set; }

		internal GraphResult(WWW result)
			: base(null)
		{
		}

		private void Init(string rawResult)
		{
		}
	}
}
