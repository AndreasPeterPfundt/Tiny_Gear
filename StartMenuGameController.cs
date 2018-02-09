using UnityEngine;
using System.Collections;

public class StartMenuGameController : MonoBehaviour
{	
	// UPDATE.
	void Update () // Let the MENU button return the player to the home screen.
	{
		#if UNITY_TVOS // Hash Tag If Unity Television Operating System.
		AppleTelevisionOperatingSystemControls (); // APPLE TELEVISION OPERATING SYSTEM CONTROLS.
		#endif // Hash Tag End If.
	}

	// APPLE TELEVISION OPERATING SYSTEM CONTROLS.
	void AppleTelevisionOperatingSystemControls () // Let the MENU button return the player to the home screen.
	{
		Debug.Log ("TINY GEAR Apple Television Operating System Controls");

		UnityEngine.Apple.TV.Remote.allowExitToHome = true;
	}
}