using UnityEngine;
using System.Collections;

public class SwapSpriteOnTick : MonoBehaviour {
	private SpriteRenderer spriteRenderer;
	private bool localTickClock;
	public Sprite sprite1;
	public Sprite sprite2;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Global.tickClock != localTickClock ) {
			localTickClock = Global.tickClock;
			//Change Sprite
			if(Global.tickClock){
				spriteRenderer.sprite = sprite1;
			}
			else{
				spriteRenderer.sprite = sprite2;
			}
		}
	}
}
