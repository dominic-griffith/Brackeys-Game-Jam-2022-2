using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{
    private bool gameover = false;
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "spike") {
			if (!gameover) {
				SceneLoader.GetInstance().OnlineLoadSceneByName("PlayTestScene");
				Debug.Log("dead by spike");
				gameover = true;
      	  	}
		}
		if (other.tag == "light" && gameObject.tag == "black") {
			if (!gameover) {
				SceneLoader.GetInstance().OnlineLoadSceneByName("PlayTestScene");
				Debug.Log("dead by light");
				gameover = true;
      	  	}
		}
		if (other.tag == "dark" && gameObject.tag == "white") {
			if (!gameover) {
				SceneLoader.GetInstance().OnlineLoadSceneByName("PlayTestScene");
				Debug.Log("dead by dark");
				gameover = true;
      	  	}
		}
	}
}
