using UnityEngine;

public class Collision : MonoBehaviour {
	//as soon as a collision happens, this function will be called

	public Movement movt;

	void OnCollisionEnter(Collision collisioninfo){
		if (collisioninfo.GetComponent<Collider>().tag == "obst")
			movt.enabled = false;
	}

}
