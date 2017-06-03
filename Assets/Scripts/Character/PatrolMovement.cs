using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Character))]
public class PatrolMovement : MonoBehaviour {
	private int targetPoint;
	private int pointLength;
	private Character character;
	public Transform[] patrolPoints;
	void Start(){
		this.character = this.GetComponent<Character>();
		this.pointLength = this.patrolPoints.Length;
		this.targetPoint = 0;
		this.transform.position = patrolPoints[this.targetPoint].position;
		this.changeTarget();
	}

	void Update(){
		this.move();
		this.checkPoint();
	}
	void checkPoint(){
		if(this.transform.position == this.patrolPoints[this.targetPoint].position){
			this.changeTarget();
		}
	}
	void move(){
		float step = this.character.speed * Time.deltaTime;
		this.transform.position = Vector3.MoveTowards(this.transform.position, this.patrolPoints[targetPoint].position, step);
	}
	void changeTarget(){
		this.targetPoint = this.targetPoint >= this.pointLength-1 ? 0 : ++this.targetPoint;
	}
}
