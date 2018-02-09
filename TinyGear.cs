using UnityEngine;
using System.Collections;

public class TinyGear : MonoBehaviour
{
	public bool bIsLeftWall; // Boolean Is Left Wall.
	public bool bIsRightWall; // Boolean Is Right Wall.

	private float fSpeed; // Float Rotation Speed.

	private Rigidbody2D rTinyGear; // Rigidbody 2-Dimensional Tiny Gear.

	private Vector2 vTinyGear; // Vector 2 Tiny Gear.

	// AWAKE.
	void Awake ()
	{
		rTinyGear = GetComponent <Rigidbody2D> ();
	}

	// UPDATE.
	void Update () // Player taps the screen to move. Player presses the space bar to move. Player clicks to move.
	{
		#if UNITY_IOS // Hash Tag If Unity I Operating System.
		AppleIOperatingSystemControls (); // APPLE I OPERATING SYSTEM CONTROLS.
		#endif // Hash Tag End If.

		#if UNITY_TVOS // Hash Tag Unity Television Operating System.
		AppleTelevisionOperatingSystemControls (); // APPLE TELEVISION OPERATING SYSTEM CONTROLS.
		#endif // Hash Tag End If.
	}

	// FIXED UPDATE.
	void FixedUpdate () // Spin the gear left or right depending on the wall it is touching.
	{
		Animation (); // ANIMATION.
	}

	// APPLE I OPERATING SYSTEM.
	void AppleIOperatingSystemControls () // Player taps the screen to move.
	{
		Debug.Log ("TINY GEAR I Operating System Controls");

		if	(bIsLeftWall == true // If Boolean Is Left Wall Is Equal True...
			&& Input.touchCount > 0f // And If Touch Count Greater Than Zero Float...
			&& Input.GetTouch (0).phase == TouchPhase.Began) // And If Phase Is Equal Began.
		{
			vTinyGear = new Vector2 (300f, 0f);

			rTinyGear.velocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRightWall == true // Boolean Is Right Wall Is Equal true...
			&& Input.touchCount > 0f // And If Touch Count Greater Than Zero Float...
			&& Input.GetTouch (0).phase == TouchPhase.Began) // And If Phase Is Equal Began.
		{
			vTinyGear = new Vector2 (-300f, 0f);

			rTinyGear.velocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	// APPLE TELEVISION OPERATING SYSTEM CONTROLS.
	void AppleTelevisionOperatingSystemControls () // Player clicks to move.
	{
		Debug.Log ("TINY GEAR Apple Television Operating System Controls");

		if	(bIsLeftWall == true // If Boolean Is Left Wall Is Equal True...
			&& Input.GetKey (KeyCode.JoystickButton14)) // And If Joystick One Button Fourteen.
		{
			vTinyGear = new Vector2 (300f, 0f);

			rTinyGear.velocity = vTinyGear * Time.smoothDeltaTime;
		}
		else if (bIsRightWall == true // Boolean Is Right Wall Is Equal true...
			&& Input.GetKey (KeyCode.JoystickButton14)) // And If Joystick One Button Fourteen.
		{
			vTinyGear = new Vector2 (-300f, 0f);

			rTinyGear.velocity = vTinyGear * Time.smoothDeltaTime;
		}
	}

	// ANIMATION.
	void Animation () // Spin the gear left or right depending on the wall it is touching.
	{
		Debug.Log ("TINY GEAR Rotation");

		fSpeed = 300f;

		if (bIsLeftWall == true) // Boolean Is Left Wall Is Equal True.
		{
			rTinyGear.MoveRotation (rTinyGear.rotation + fSpeed * Time.fixedDeltaTime);
		} // End If.
		
		if (bIsRightWall == true) // Boolean Is Right Wall Is Equal True.
		{
			rTinyGear.MoveRotation (rTinyGear.rotation + -fSpeed * Time.fixedDeltaTime);
		} // End If.
	}
}