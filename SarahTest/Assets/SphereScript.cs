using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

	public Material inactiveMaterial;
	public Material gazedAtMaterial;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material = inactiveMaterial;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Testing laser pointer collision
	public void PointedAt() {
		Debug.Log ("HI");
		GetComponent<Renderer>().material = gazedAtMaterial;
	} 

	// Testing laser pointer exit
	public void PointerLeaves() {
		Debug.Log ("BYE");
		GetComponent<Renderer>().material = inactiveMaterial;
	}
}
