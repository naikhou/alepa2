using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFollow : MonoBehaviour {

	private Vector2 velocity;

	public float smoothTimeY;
	public float smoothTimeX;
	public float i = -0.3f;

	public GameObject player;
	/// <summary>
	/// Start this instance.
	/// </summary>
	void Start () {
	}
	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update () {

		float posX = Mathf.SmoothDamp (transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
		//smooths x-axis movement

		transform.position = new Vector3 (posX+i, 1, transform.position.z); 
		// Doesn't affact z-axis
	}
}
