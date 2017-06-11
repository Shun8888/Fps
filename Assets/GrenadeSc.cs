using UnityEngine;
using System.Collections;

public class GrenadeSc : MonoBehaviour {
	public GameObject prefab_bom;
	

	// Use this for initialization
	void Start () {
		StartCoroutine ("bom");
	
	}
	IEnumerator bom(){
		yield return new WaitForSeconds (2.5f);
		Destroy (gameObject);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
