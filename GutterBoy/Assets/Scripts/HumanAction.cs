using UnityEngine;
using System.Collections;

public class HumanAction : MonoBehaviour {

	[SerializeField]
	private float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move(){
		this.gameObject.transform.Translate (0, 0, speed);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Exit") {
			Destroy (this.gameObject);
		}

	}
}
