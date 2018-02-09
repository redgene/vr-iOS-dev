using UnityEngine;

public class FollowerForCamera : MonoBehaviour {

	public Transform sphere; //drag and drop our gameobject sphere here.
	public Vector3 offset  ; //set the offset vector in the inspector

	void Update () {
		transform.position = sphere.position - offset; //only this line causes camera to be stuck inside sphere

	}
}
