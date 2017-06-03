using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Character))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {
	private Character character;
	private Rigidbody rigidBody;

	void Start () {
		this.character = this.GetComponent<Character>();
		this.rigidBody = this.GetComponent<Rigidbody>();
	}

	public void applyForce(Vector3 direction){
		this.rigidBody.AddForce(direction * character.speed * 3);
	}
}
