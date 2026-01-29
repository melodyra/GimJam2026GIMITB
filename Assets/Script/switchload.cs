using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swtichload : MonoBehaviour
{
    [SerializeField] GameObject input;
    [SerializeField] GameObject output;
    public AudioSource soundEffect;
    public void loading()
    {
        if (soundEffect != null) soundEffect.Play(); 
        input.SetActive(false);
        output.SetActive(true);
    }
}