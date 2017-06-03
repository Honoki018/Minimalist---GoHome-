using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionAction : MonoBehaviour {
	public enum ActionOnCollisiton{DestroyAction, RespawnAction};
	public ActionOnCollisiton actionOnCollisiton;
	public string[] collisionTags;

	void OnCollisionEnter(Collision collision){
		foreach(string tag in collisionTags){
			if(collision.gameObject.tag == tag){
				appendComponent(this.actionOnCollisiton, collision.gameObject);
			}
		}
	}

	void appendComponent(ActionOnCollisiton action, GameObject gameObject){
		switch(action){
			case ActionOnCollisiton.DestroyAction:{
				gameObject.AddComponent<DestroyAction>();
				break;
			}
			case ActionOnCollisiton.RespawnAction:{
				gameObject.AddComponent<RespawnAction>();
				break;
			}
		}
	}
}
