using UnityEngine;
using System.Collections;

public class Enemysc : MonoBehaviour {

	public Transform target;
	UnityEngine.AI.NavMeshAgent agent;
	int enemyHP = 5;
	public GameObject explosion2;

	void Start () {
		GameObject player = GameObject.Find ("FPSController");
		target = player.transform;
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	
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
			GameObject effect = Instantiate (explosion2, transform.position, Quaternion.identity)as GameObject;
			Destroy (this.gameObject);
		}
	}

	void BigDamage(){
		ScoreSc.EnemyCount += 1;
		Destroy (this.gameObject);
	}

		


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "GameController") {
			col.SendMessage ("PlayerDamage"); //ダメージを与えて
			Destroy (this.gameObject);

		}
	}
}
		
	

