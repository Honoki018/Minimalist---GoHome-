using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameManager))]
public class InputManager : MonoBehaviour {
	private GameManager gameManager;
	void Start () {
		gameManager = GetComponent<GameManager>();
	}
	
	void FixedUpdate () {
		gameManager.axisInput(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}
}
