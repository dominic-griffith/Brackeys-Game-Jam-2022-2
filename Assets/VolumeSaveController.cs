using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeSaveController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private TextMeshProUGUI volumeTextUI = null;

    private void Start() {
        if (!PlayerPrefs.HasKey("VolumeValue")) {
            volumeTextUI.text = "0.5";
            volumeSlider.value = 0.5f;
        } else {
            LoadValues();
        }
    }

    public void VolumeSlider(float volume) {
        volumeTextUI.text = volume.ToString("0.0");
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    void LoadValues() {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }

}
