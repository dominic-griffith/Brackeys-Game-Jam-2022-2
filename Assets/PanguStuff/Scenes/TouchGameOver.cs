using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class TouchGameOver : MonoBehaviour
{
    private bool gameover = false;
	private void OnTriggerEnter2D(Collider2D other) {
        if (!gameover) {
            SceneLoader.GetInstance().OnlineLoadSceneByName("PlayTestScene");
            Debug.Log("dead by terrain");
            gameover = true;
        }
    }
}