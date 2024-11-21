using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public AudioClip[] StepSounds;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void PlayStepSound()
    {
        AudioClip clip = StepSounds[(int)Random.Range(0, StepSounds.Length)];
        source.clip = clip;
        source.Play();
    }
}