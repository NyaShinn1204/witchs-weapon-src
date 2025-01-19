using System.Collections.Generic;
using UnityEngine;

public class GEffectLine : MonoBehaviour
{
	public enum GEffectLineDraw
	{
		Line = 0,
		BezierRandom = 1,
		BezierLeft = 2,
		BezierRight = 3,
		BezierTop = 4,
		BezierBottom = 5
	}

	public enum GEffectLineAnim
	{
		None = 0,
		Source2Target = 1,
		Target2Source = 2
	}

	public enum GEffectLineType
	{
		Sign = 0,
		Both = 1
	}

	private class SamplePoint
	{
		public Vector3 point;

		public Quaternion rotation;

		public float distance;

		public float time;
	}

	private class SampleView
	{
		public GameObject view;

		public List<SamplePoint> samplePoint;

		public Mesh trailMesh;

		public Material material;

		public GMathBezier.BezierData bezierData;

		public float time;

		public int frame;

		public Transform source;

		public Entity sourceEntity;

		public Entity target;

		public bool isFinished;

		private List<Vector3> bezierPoint;

		public bool tempDrawView;

		public GameObject effectViewEnd;

		public bool isChangePosition
		{
			get
			{
				return false;
			}
		}

		public void modfineBezier(float sTotalTime)
		{
		}

		public void mathBezier(GEffectLineDraw sLineDraw)
		{
		}
	}

	[SerializeField]
	private GEffectLineDraw _typeLineDraw;

	[SerializeField]
	private GEffectLineAnim _typeLineAnimStart;

	[SerializeField]
	private GEffectLineAnim _typeLineAnimEnd;

	[SerializeField]
	private GEffectLineType _typeLineType;

	[SerializeField]
	private Material _material;

	[SerializeField]
	private long _effectStart;

	[SerializeField]
	private long _effectEnd;

	private GameObject _effectViewStart;

	[SerializeField]
	private float _lifeTime;

	[SerializeField]
	private Vector3 _offsetLocation;

	[SerializeField]
	private float[] _width;

	[SerializeField]
	private float _tilingMul;

	private List<SampleView> _viewList;

	private Transform _source;

	private List<Entity> _entity;

	private bool _isBreak;

	private bool _isDebug;

	private FunctionEntity _finishedHD;

	public static GEffectLine show(long sID, Transform sSource, List<Entity> sTarget, FunctionEntity sHD)
	{
		return null;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void eventSample(SampleView sView)
	{
	}

	private void eventDraw(SampleView sView)
	{
	}

	public void Break()
	{
	}

	public void destroy()
	{
	}
}
