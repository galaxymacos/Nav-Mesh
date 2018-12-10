using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {
	
	/// <summary>
	/// If enemy catches you, restart the game
	/// </summary>
	/// <param name="other"></param>
	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "You") {
			SceneManager.LoadScene("SampleScene");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
