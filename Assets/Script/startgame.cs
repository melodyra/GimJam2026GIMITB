using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public AudioSource soundEffect;
    private int sceneId; 

    public void MovetoScene(int id)
    {
        sceneId = id; 
        if (soundEffect != null) soundEffect.Play();
        Invoke("Load", 1f); 
    }

    void Load()
    {
        SceneManager.LoadScene(sceneId);
    }
}