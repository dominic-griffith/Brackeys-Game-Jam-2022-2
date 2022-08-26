using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;

    public void Awake()
    {
        if (Instance == null)
        {

            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static SceneLoader GetInstance()
    {
        return Instance;
    }



    public int GetCurrentScene()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


    //Offline Loading

    public void OfflineLoadSceneByNumber(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OfflineLoadSceneByName(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OfflineReloadScene()
    {
        SceneManager.LoadScene(GetCurrentScene());
    }


    //Online Loading

    public void OnlineLoadSceneByNumber(int scene)
    {
        PhotonNetwork.LoadLevel(scene);
    }

    public void OnlineLoadSceneByName(string scene)
    {
        PhotonNetwork.LoadLevel(scene);
    }

    public void OnlineReloadScene()
    {
        PhotonNetwork.LoadLevel(GetCurrentScene());
    }
}
