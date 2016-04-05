using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour 
{
	public Transform target;
	public float dampSpeed;
	public float directionOffset;

	private Vector3 _offset;
	private Vector3 _velocity = Vector3.zero;

	void Start()
	{
		_offset = transform.position - target.transform.position;
	}

	void FixedUpdate()
	{
		Vector3 targetPos = (target.position + _offset) + (target.forward * directionOffset);
		//transform.position = targetPos + _offset;
		transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _velocity, dampSpeed);
	}
}
