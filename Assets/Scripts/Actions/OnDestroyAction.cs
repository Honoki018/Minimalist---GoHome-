using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroyAction : MonoBehaviour {
	public GameObject instantiateObject;
	// Use this for initialization
	public void instantiateBeforeDestroy(){
		if(instantiateObject){
			Instantiate(this.instantiateObject, this.transform.position, Quaternion.identity);
		}
	}
}
