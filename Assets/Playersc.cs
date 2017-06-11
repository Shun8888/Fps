using UnityEngine;
using System.Collections;

public class Playersc : MonoBehaviour {

	public Camera camera;
	public AudioSource Gunsound;
	public GameObject prefab_bom;


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
		if(Input.GetMouseButtonDown(1))
			{
				BomDamage();
			}

	}
	void PlayerDamage(){
		playerHP -= 1;
		Debug.Log (playerHP);
	}


	void BomDamage(){
		Vector3 pos =transform.position + transform.TransformDirection (Vector3.forward);
		GameObject bom = Instantiate (prefab_bom, pos, Quaternion.identity)as GameObject;

		Vector3 bom_speed = transform.TransformDirection (Vector3.forward) * 5;
		bom_speed += Vector3.up * 5;
		bom.GetComponent<Rigidbody> ().velocity = bom_speed;

		bom.GetComponent<Rigidbody> ().angularVelocity = Vector3.forward * 7;
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


