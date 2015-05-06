using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas ExitMenu;
	public Button startText;
	public Button exitText;


	// Use this for initialization
	void Start () {

		ExitMenu = ExitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		ExitMenu.enabled = false;

	
	}
	

	public void ExitPress()
	{
		ExitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress()
	{
		ExitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel()
	{
		Application.LoadLevel (1);
	}

	public void ExitGame ()
	{
		Application.Quit ();
	}

}
