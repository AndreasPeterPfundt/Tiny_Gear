using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour
{
	private AudioSource aDevil; // Audio source Devil.

	// AWAKE.
	void Awake ()
	{
		aDevil = GetComponent <AudioSource> ();
	}

	// START GAME.
	public void StartGame () // Play the game.
	{
		Debug.Log ("START BUTTON Start Game");

		aDevil.Play ();

		Application.LoadLevel ("MainScene");
	}
}