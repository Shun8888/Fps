using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreSc : MonoBehaviour {

	public Text Scorelabel;
	public static int EnemyCount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Scorelabel.text = EnemyCount.ToString ();
	}
}
