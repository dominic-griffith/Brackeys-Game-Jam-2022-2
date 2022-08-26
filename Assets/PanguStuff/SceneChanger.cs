using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// play scene is 1, settings is 2?

public class SceneChanger : MonoBehaviour
{
    public Animator animator;

    private int sceneToLoad;

    public void OnPlayClick() {
        Debug.Log("Game is playing");
        FadeToScene(1);
    }

    public void doExitGame() {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    public void FadeToScene(int sceneIndex) {
        sceneToLoad = sceneIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete() {
        SceneManager.LoadScene(sceneToLoad);
    }
}