using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour {
	public GameObject playerPrefab;
	public Transform startingPoint;
	public PlayerMovement playerMovement;
	public Goal goal;

	public void axisInput(float horizontal, float vertical){
		
		if(playerMovement){
			Vector3 direction = new Vector3(horizontal, 0, vertical);
			playerMovement.applyForce(direction);
		} else {
			playerCheck();
		}
	}
	void playerCheck(){
		if(!playerMovement){
			playerMovement = (Instantiate(this.playerPrefab, startingPoint.position, Quaternion.identity) as GameObject).GetComponent<PlayerMovement>();
		}
	}
}
