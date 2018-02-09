﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI; // USER INTERFACE.

public class LeftWall : MonoBehaviour
{
	private AudioSource aGod; // Audio Source Alive.

	private GameObject gScoreText; // Game Object Score Text.
	private GameObject gTinyGear; // Game Object Tiny Gear;

	private TinyGear tTinyGear; // Tiny Gear Tiny Gear.

	private Rigidbody2D rTinyGear; // Rigidbody 2-Dimensional Tiny Gear.

	private ScoreText sScoreText; // Score Text Score Text.

	private Vector2 vTinyGear; // Vector 2 Tiny Gear.

	// VOID AWAKE.
	void Awake () // Checking to see if Tiny Gear exhists.
	{
		aGod = GetComponent <AudioSource> ();
		gScoreText = GameObject.FindGameObjectWithTag ("ScoreText");
		gTinyGear = GameObject.FindGameObjectWithTag ("Player");

		TinyGearNotDestroyed (); // TINY GEAR NOT DESTROYED.
	}

	// ON TRIGGER ENTER TWO-DIMENSIONAL.
	void OnTriggerEnter2D (Collider2D other) // Player is on the left or right wall.
	{
		Debug.Log ("LEFT WALL On Trigger Two-Dimensional");

		if (other.CompareTag ("Player")) // If Other Compare Tag Player.
		{
			if (tTinyGear.bIsLeftWall == false // If Boolean Is Left Wall Is Equal False...
				&& tTinyGear.bIsRightWall == true) // And If Boolean Is Right Wall Is Equal True.
			{
				sScoreText.iScore++; // Integer Score Plus Plus.

				aGod.Play ();
			} // End If.

			tTinyGear.bIsLeftWall = true; // Boolean Is Left Wall Equal True.
			tTinyGear.bIsRightWall = false; // Boolean Is Right Wall Equal False.
			vTinyGear = new Vector2 (0f, 0f);
			rTinyGear.velocity = vTinyGear;
			vTinyGear = new Vector2 (-1.854466f, -2.5f);
			rTinyGear.transform.position = vTinyGear;
		} // End If.
	}

	// TINY GEAR NOT DESTROYED.
	void TinyGearNotDestroyed () // Checking to see if Tiny Gear exhists.
	{
		Debug.Log ("LEFT WALL Tiny Gear Not Destroyed");

		if (gTinyGear != null) // If Game Object Tiny Gear Not Equal Null.
		{
			tTinyGear = gTinyGear.GetComponent <TinyGear> ();
			rTinyGear = gTinyGear.GetComponent <Rigidbody2D> ();
			sScoreText = gScoreText.GetComponent <ScoreText> ();
		} // End If.
	}
}