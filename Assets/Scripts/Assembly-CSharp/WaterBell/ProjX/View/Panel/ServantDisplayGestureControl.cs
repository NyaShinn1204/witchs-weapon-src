using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantDisplayGestureControl : MonoBehaviour
	{
		private const string MODEL_PATH = "UI/KanbanPosture/Model/";

		private const string FSM_PATH = "UI/KanbanPosture/FSM/";

		private const string CONTROLLER_PATH = "UI/KanbanPosture/Controller/";

		private static ServantDisplayGestureControl current;

		private static long currentID;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public static void SetGesture(long id)
		{
		}
	}
}
