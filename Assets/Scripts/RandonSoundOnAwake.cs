using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandonSoundOnAwake : MonoBehaviour
{
    public List<AudioClip> audioClips;
    private AudioSource thisAudioSource;

    void Awake() {
        thisAudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start() {
        
        //Play random clip
        AudioClip audioClip = audioClips[Random.Range(1, audioClips.Count)];
        thisAudioSource.PlayOneShot(audioClip);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
