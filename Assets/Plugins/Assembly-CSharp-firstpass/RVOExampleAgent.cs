using System.Collections.Generic;
using Pathfinding;
using Pathfinding.RVO;
using UnityEngine;

public class RVOExampleAgent : MonoBehaviour
{
	public float repathRate;

	private float nextRepath;

	private Vector3 target;

	private bool canSearchAgain;

	private RVOController controller;

	private Path path;

	private List<Vector3> vectorPath;

	private int wp;

	public float moveNextDist;

	private Seeker seeker;

	private MeshRenderer[] rends;

	public void Awake()
	{
	}

	public void Start()
	{
	}

	public void SetTarget(Vector3 target)
	{
	}

	public void SetColor(Color col)
	{
	}

	public void RecalculatePath()
	{
	}

	public void OnPathComplete(Path _p)
	{
	}

	public void Update()
	{
	}
}
