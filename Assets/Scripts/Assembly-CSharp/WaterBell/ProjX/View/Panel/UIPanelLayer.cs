using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIPanelLayer : MonoBehaviour
	{
		private static bool s_Init;

		private static int s_Depth;

		private static Dictionary<UIPanelLayerTypes, List<UIPanelLayer>> layerDict;

		private static HashSet<UIPanelLayerTypes> dirtySet;

		[SerializeField]
		private List<UIPanel> panelList;

		[SerializeField]
		private int depth;

		[SerializeField]
		private UIPanelLayerTypes layerType;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDisable()
		{
		}

		private void SetDepth()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void SetLayer(UIPanelLayerTypes layerType)
		{
		}

		public static void SetDirty()
		{
		}

		public static void SetDirty(UIPanelLayerTypes layer)
		{
		}

		private static void UpdateLayers()
		{
		}

		private static void Init()
		{
		}
	}
}
