using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameManager gameManager = GameObject.FindObjectOfType<GameManager>();
		this.transform.position = gameManager.startingPoint.position;
		Destroy(this.GetComponent<RespawnAction>());
	}
}
