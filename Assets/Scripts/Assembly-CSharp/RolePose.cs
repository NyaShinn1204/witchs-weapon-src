using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using UnityEngine;

public class RolePose : MonoBehaviour
{
	private FSMOwner fmsOwner;

	private Blackboard blackboard;

	private Animator anim;

	private void Awake()
	{
	}

	public void Init(long id)
	{
	}

	public static RolePose Create(long id, Transform parent)
	{
		return null;
	}
}
