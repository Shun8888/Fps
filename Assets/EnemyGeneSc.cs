using UnityEngine;
using System.Collections;

public class EnemyGeneSc : MonoBehaviour {

	public GameObject enemy;

	void Start () {
		InvokeRepeating ("Generate", 0, 5);
		
	
	}
	void Generate () {
		Instantiate (enemy, transform.position, transform.rotation);
	
	}
}
