using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class soundManager : MonoBehaviour
{
    public float volume;
    public AudioMixer mixer;

    public void SetVolume(float volume)
    {
        mixer.SetFloat("Volume", volume);
    }
}