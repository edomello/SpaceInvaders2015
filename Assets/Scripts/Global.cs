using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {
	public static Global instance;
	public static float lastTick;
	public static bool tickClock;
	public static float tickTime = 0.5f;
	public static float max_x = 8f;
	public static float max_y;
	public static float enemyStepLeftRight = 0.5f;
	public static float enemyStepDown;


	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		else
			DestroyObject (this);
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time - lastTick > tickTime) {
			lastTick = Time.time;
			tickClock = !tickClock;
		}
	}
}
