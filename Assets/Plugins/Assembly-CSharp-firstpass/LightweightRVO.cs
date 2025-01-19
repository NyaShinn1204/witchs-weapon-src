using System.Collections.Generic;
using Pathfinding.RVO;
using UnityEngine;

public class LightweightRVO : MonoBehaviour
{
	public enum RVOExampleType
	{
		Circle = 0,
		Line = 1,
		Point = 2,
		RandomStreams = 3
	}

	public int agentCount;

	public float exampleScale;

	public RVOExampleType type;

	public float radius;

	public float maxSpeed;

	public float agentTimeHorizon;

	[HideInInspector]
	public float obstacleTimeHorizon;

	public int maxNeighbours;

	public float neighbourDist;

	public Vector3 renderingOffset;

	private Mesh mesh;

	private Simulator sim;

	private List<IAgent> agents;

	private List<Vector3> goals;

	private List<Color> colors;

	private Vector3[] verts;

	private Vector2[] uv;

	private int[] tris;

	private Color[] meshColors;

	private Vector3[] interpolatedVelocities;

	public void Start()
	{
	}

	public void OnGUI()
	{
	}

	private float uniformDistance(float radius)
	{
		return 0f;
	}

	public void CreateAgents(int num)
	{
	}

	public void Update()
	{
	}

	private static Color HSVToRGB(float h, float s, float v)
	{
		return default(Color);
	}
}
