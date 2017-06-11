using UnityEngine;
using System.Collections;

public class Enemysc : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;
	int enemyHP = 5;

	void Start () {
		GameObject player = GameObject.Find ("FPSController");
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();
	
	}

	void Update () {
		//プレイヤー追いかける
		agent.SetDestination (target.position);
		Debug.Log (ScoreSc.EnemyCount);
	}
	void Damage(){
		enemyHP -= 1;
		if (enemyHP == 0) {
			ScoreSc.EnemyCount += 1;
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "FPSController") {
			if (other.gameObject.name == "FPSController") {
				other.gameObject.SendMessage ("PlayerDamage");
				Destroy (this.gameObject);
			}
		}
	}
}
