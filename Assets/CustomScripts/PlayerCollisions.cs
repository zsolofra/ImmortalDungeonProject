using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollisions : MonoBehaviour 
{

	bool triggered = false;
	int  numLit = 0;
	public GameObject textGameObject;
	public GameObject obstructionGameObject;

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Fire") {


			if (triggered == false) {
				Debug.Log("triggered");
				triggered = true;
				numLit ++;
				Debug.Log(numLit);
				col.GetComponent<ParticleSystem>().enableEmission = true;
			}

		} //end of if its a fire

		if (col.gameObject.tag == "Obstruction") {

			if (numLit >= 4) {
			col.GetComponent<ParticleSystem>().enableEmission = true;
				StartCoroutine(Wait(5.0f));

			}else {
			Text text = textGameObject.GetComponent<Text>();
			text.text = "Light the Fires to Pass";
			}



		} //end of if its a obstruction

	}


	void OnTriggerExit (Collider col) {
		if (col.gameObject.tag == "Fire") {
			if (triggered == true) {
				Debug.Log ("untriggered");
				triggered = false;
			}
		}

		if (col.gameObject.tag == "Obstruction") {
			
			Text text = textGameObject.GetComponent<Text>();
			text.text = "";


		}
	}

	private IEnumerator Wait(float seconds)
	{
		Debug.Log("waiting");
		yield return new WaitForSeconds(seconds);

		Debug.Log("Booom");
		Destroy(obstructionGameObject);
	}
}
