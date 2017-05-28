using UnityEngine;
using System.Collections;

public class Enemysc : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;
	int enemyHP = 3;

	void Start () {
		GameObject player = GameObject.Find ("FPSController");
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();
	
	}

	void Update () {
		//プレイヤー追いかける
		agent.SetDestination (target.position);
	}
	void Damage(){
		enemyHP -= 1;
		if (enemyHP == 0) {
			Destroy (this.gameObject);
		}
	}
}
