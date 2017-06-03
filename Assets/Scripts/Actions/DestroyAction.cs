using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		OnDestroyAction onDestroyAction = GetComponent<OnDestroyAction>();
		if(onDestroyAction){
			onDestroyAction.instantiateBeforeDestroy();
		}
		Debug.Log(this.name + " destroyed!");
		Destroy(this.gameObject);
	}
}
