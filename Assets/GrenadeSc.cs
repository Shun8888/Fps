using UnityEngine;
using System.Collections;

public class GrenadeSc : MonoBehaviour {
	public GameObject explosion;
	

	// Use this for initialization
	void Start () {
		StartCoroutine ("bom");
	
	}
	IEnumerator bom(){
		yield return new WaitForSeconds (2.5f);
		GameObject effect = Instantiate (explosion, transform.position, Quaternion.identity)as GameObject;
		Destroy(effect , 1.2f);
		Destroy (gameObject);
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
