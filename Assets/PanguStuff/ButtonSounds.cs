using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{

    [SerializeField] private AudioClip buttonDownSound, buttonUpSound;

    private AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlayDownSound() {
        audioSrc.PlayOneShot(buttonDownSound);
    }

    public void PlayUpSound() {
        audioSrc.PlayOneShot(buttonUpSound);
    }
}
