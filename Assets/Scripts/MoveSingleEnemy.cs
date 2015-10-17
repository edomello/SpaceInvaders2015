using UnityEngine;
using System.Collections;

public class MoveSingleEnemy : MonoBehaviour {
	private bool localTickClock;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Global.tickClock != localTickClock) {
			localTickClock = Global.tickClock;
			//Move
			transform.position = transform.position + EnemyMovement.getNextMovement()*Global.enemyStepLeftRight;
			//Check if colliding the border
			if (transform.position.x + Global.enemyStepLeftRight >= Global.max_x) EnemyMovement.setCollidingRight();
			if (transform.position.x - Global.enemyStepLeftRight <= -Global.max_x) EnemyMovement.setCollidingLeft();

		}
	}
}
