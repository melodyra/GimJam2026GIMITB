using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playbgm : MonoBehaviour
{
    [SerializeField] AudioSource bgm;
    float volumesuara = 0;
    public void play()
    {
        if (PlayerPrefs.HasKey("musicvolume"))
        {
            volumesuara = PlayerPrefs.GetFloat("musicvolume");
        }
        bgm.volume = volumesuara;
        bgm.Play();
    }
    void Update()
    {
        if (PlayerPrefs.HasKey("musicvolume"))
        {
            volumesuara = PlayerPrefs.GetFloat("musicvolume");
        }
        bgm.volume = volumesuara;
    }
}
