﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
	/*initializing health, damage, speed, animator...
	 * 
	 */
	public int healthPoints = 2;
	public int attackDamage = 1;
	public float speed = 2.5f;




	private bool dead = false;
	private Transform frontcheck;
	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake ()
	{
		
		frontcheck = transform.Find ("frontcheck").transform;

	}
	/// <summary>
	/// Fixeds the update.
	/// </summary>
	// Update is called once per frame
	void FixedUpdate ()
	{
		//if enemy hits an obstacle, it turns around
		Collider2D[] frontHits = Physics2D.OverlapPointAll (frontcheck.position, 1);
		foreach (Collider2D c in frontHits) {
			if (c.tag == "Obstacle") {
				Flip ();
				break;
			}
		}
		//enemy movement and dying if health goes to zero
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (transform.localScale.x * speed, GetComponent<Rigidbody2D> ().velocity.y);
		if (healthPoints <= 0 && !dead)
			Death ();
	}
	/// <summary>
	/// Loses health.
	/// </summary>
	public void LoseHealth ()
	{
		healthPoints--;
	}
	/// <summary>
	/// Death this instance.
	/// </summary>
	public void Death ()
	{
		dead = true;
	}
	/// <summary>
	/// Flip this instance.
	/// </summary>
	void Flip ()
	{
		Vector3 EnemyScale = transform.localScale;
		EnemyScale.x *= -1;
		transform.localScale = EnemyScale;
	}
	/// <summary>
	/// Raises the trigger enter2 d event.
	/// </summary>
	/// <param name="col">Col.</param>
	public void OnTriggerEnter2D (Collider2D col)
	{
		//if player hits enemies, it loses health
		//if health reaches zero, player dies
		if (col.gameObject.tag == "Player") {
			
			col.gameObject.GetComponent<PlayerController> ().health -= attackDamage;

			if (col.gameObject.GetComponent<PlayerController> ().health <= 0) {

				col.gameObject.GetComponent<PlayerController> ().alive = false;


				Time.timeScale = 0;

			}
		}
	}	
}


	
	

