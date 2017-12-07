using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {
	//Creating the canvases
	public Canvas MainCanvas;
	public Canvas HelpCanvas;
	public Canvas CreditsCanvas;
	public Canvas StoryCanvas;
	/// <summary>
	/// Awake this instance.
	/// </summary>
	//Disabling the HelpCanvas and CreditsCanvas on startup
	void Awake()
	{
		HelpCanvas.enabled = false;
		CreditsCanvas.enabled = false;
		StoryCanvas.enabled = false;
	}
	/// <summary>
	/// Story on.
	/// </summary>
	public void StoryOn()
	{
		StoryCanvas.enabled = true;
		MainCanvas.enabled = false;
	}
	/// <summary>
	/// Help on.
	/// </summary>
	//Creating a method for opening the HelpCanvas
	public void HelpOn()
	{
		HelpCanvas.enabled = true;
		MainCanvas.enabled = false;
	}
	/// <summary>
	/// Credits on.
	/// </summary>
	public void CreditsOn()
	{
		CreditsCanvas.enabled = true;
		MainCanvas.enabled = false;
	}
	/// <summary>
	/// Back on.
	/// </summary>
	//This method returns the user back to the main canvas
	public void BackOn()
	{
		HelpCanvas.enabled = false;
		CreditsCanvas.enabled = false;
		MainCanvas.enabled = true;
		StoryCanvas.enabled = false;
	}
	/// <summary>
	/// Finds the game.
	/// </summary>
	//This method finds the game the menu is supposed to launch
	public void FindGame (){
		SceneManager.LoadScene ("Alepa");
	}
	/// <summary>
	/// Quit button.
	/// </summary>
	//This method quits the game	
	public void QuitButton ()
	{
		Application.Quit ();
	}
}
