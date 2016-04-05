using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float attackRange = 1f;

	private NavMeshAgent _navmesh;
	private Transform _player;

	void Awake() {
		_navmesh = GetComponent<NavMeshAgent> ();
		_player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update()
	{
		_navmesh.SetDestination (_player.position);

		if (Vector3.Distance (_player.position, transform.position) <= 1) {
			Attack ();
		}
	}

	void Attack() {
		Debug.Log("Attack");
	}
}
