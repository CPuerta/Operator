using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_Randomizer : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    public AudioClip audioClip4;
    public AudioClip audioClip5;
    public AudioClip audioClip6;


    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        
            if (!audioSource.isPlaying)
            {
                int x = Random.Range(1, 6);
                if (x == 1)
                {
                    audioSource.clip = audioClip1;
                    audioSource.Play();
                }
                else if (x == 2)
                {
                    audioSource.clip = audioClip2;
                    audioSource.Play();
                }
                else if (x == 3)
                {
                    audioSource.clip = audioClip3;
                    audioSource.Play();
                }
                else if (x == 4)
                {
                    audioSource.clip = audioClip4;
                    audioSource.Play();
                }
                else if (x == 5)
                {
                    audioSource.clip = audioClip5;
                    audioSource.Play();
                }
                else if (x == 6)
                {
                    audioSource.clip = audioClip6;
                    audioSource.Play();
                }
            }
        }
        

    
}
