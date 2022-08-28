using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class TouchGameOver : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other) {
                SceneLoader.GetInstance().OnlineLoadSceneByName("PlayTestScene");
                Debug.Log("dead by terrain");
	}
}
