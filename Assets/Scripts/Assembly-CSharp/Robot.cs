using UnityEngine;

public class Robot : MonoBehaviour
{
	[SerializeField]
	private float m_MaxSpeed;

	[SerializeField]
	private float m_JumpForce;

	[SerializeField]
	private float m_CrouchSpeed;

	[SerializeField]
	private bool m_AirControl;

	[SerializeField]
	private LayerMask m_WhatIsGround;

	private Transform m_GroundCheck;

	private const float k_GroundedRadius = 0.2f;

	private bool m_Grounded;

	private Transform m_CeilingCheck;

	private const float k_CeilingRadius = 0.01f;

	private Animator m_Anim;

	private Rigidbody2D m_Rigidbody2D;

	private bool m_FacingRight;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Move(float move, bool crouch, bool jump)
	{
	}

	private void Flip()
	{
	}
}
