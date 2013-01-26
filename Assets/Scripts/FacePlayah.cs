<<<<<<< HEAD:Assets/Scripts/FacePlayah.cs
using UnityEngine;
using System.Collections;

public class FacePlayah : MonoBehaviour {
	GameObject player;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 face = player.transform.position;
		face.y=transform.position.y;
		transform.LookAt(face);
		
		Vector3 distance = player.transform.position-transform.position;
		
		distance.Normalize();
		
		transform.position+=distance*0.01f;
			
	
	}
}
=======
using UnityEngine;
using System.Collections;

public class FacePlayah : MonoBehaviour {
	GameObject player;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}
>>>>>>> Retrying Commit?:Assets/FacePlayah.cs
