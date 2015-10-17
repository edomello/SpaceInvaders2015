using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	private static Vector3 nextMovement;
	private static bool collidingLeft;
	private static bool collidingRight;
	private static bool localTickClock;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Global.tickClock != localTickClock) {
			localTickClock = Global.tickClock;

			if (nextMovement.Equals (Vector3.down)) {
				//If the next movement is already down, we just done it, so:
				if (collidingLeft) {
					//Some enemy is near the left border, so go right
					collidingLeft = false;
					nextMovement = Vector3.right;
				}
				if (collidingRight) {
					//Some enemy is near the right border, so go left
					collidingRight = false;
					nextMovement = Vector3.left;
				}
			} else {
				//We just moved left or right, let's check if we have reached the border
				if (collidingLeft || collidingRight) {
					//Some enemy is near the left border, so go right
					nextMovement = Vector3.down;
				}
			}
		}
	}
	public static Vector3 getNextMovement(){ return nextMovement;}
	public static void setCollidingLeft(){
		collidingLeft = true;
	}
	public static void setCollidingRight(){
		collidingRight = true;
	}
			}
		