using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        SceneLoader.GetInstance().OnlineLoadSceneByName("EndScene");
    }
}
