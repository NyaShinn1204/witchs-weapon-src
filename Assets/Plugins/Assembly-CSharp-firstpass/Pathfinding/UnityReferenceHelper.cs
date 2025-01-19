using UnityEngine;

namespace Pathfinding
{
	[ExecuteInEditMode]
	public class UnityReferenceHelper : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		private string guid;

		public string GetGUID()
		{
			return null;
		}

		public void Awake()
		{
		}

		public void Reset()
		{
		}
	}
}
