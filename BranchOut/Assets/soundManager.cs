using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class soundManager : MonoBehaviour
{
 public float Volume;
public AudioMixer mixer;

    public void SetVolume(float Volume)
    {
        mixer.SetFloat("Volume", Volume);
    }
}