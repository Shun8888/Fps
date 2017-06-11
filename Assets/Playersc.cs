using UnityEngine;
using System.Collections;

public class Playersc : MonoBehaviour {

	public Camera camera;
	public AudioSource Gunsound;

	int playerHP = 10;

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
	
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Shot ();
			Gunsound.Play ();
		}
	}
	void PlayerDamage(){
		playerHP -= 1;
		Debug.Log (playerHP);
	}
	
	void Shot ()
	{
		int distance = 50;
		Vector3 center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
		Ray ray = camera.ScreenPointToRay (center);
		RaycastHit hitInfo;
	

			if (Physics.Raycast (ray, out hitInfo, distance)) {
				if (hitInfo.collider.tag == "Enemy") {
					hitInfo.collider.SendMessage ("Damage");
				}
			}
		}
	}


