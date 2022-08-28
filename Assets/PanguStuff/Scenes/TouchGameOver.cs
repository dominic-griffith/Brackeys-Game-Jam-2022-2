using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGameOver : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("dead by terrain");
        // load both players back!!!!!!
	}
}
