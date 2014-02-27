using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	//Object which the camera will follow
	public GameObject target;
	
	// Update is called once per frame
	void Update () 
	{
		//Temporary variables for transform.position
		Vector3 temp = transform.position;
		Vector3 tempTarget = target.transform.position;

		//Change the camera's position to match the target's position
		temp.x = tempTarget.x;
		transform.position = temp;
	}


}
