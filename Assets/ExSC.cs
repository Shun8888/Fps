using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExSC : MonoBehaviour {
	
	public AudioSource EXsound;
	// Use this for initialization
	void Start () {
		EXsound.Play ();
		
		
	}
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Enemy") {
			col.SendMessage ("BigDamage"); 
		}
		if (col.gameObject.tag == "GameController") {
			col.SendMessage ("PlayerDamage");
		}
	}
}
	
	// Update is called once per framevoid Update () {
		
		
	
