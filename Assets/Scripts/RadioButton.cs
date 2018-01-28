using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton : MonoBehaviour {
    public bool Pressed;
    bool pressable = true;
    private AudioSource audioSource;
    
    private void OnTriggerEnter(Collider other)
    {

        if (Pressed)
        {
            if (pressable)
            {
                transform.position = transform.position + new Vector3(0, -.01f, 0);
                StartCoroutine(Wait());
                audioSource.Play();
                pressable = false;
            }
            else
            {
                transform.position = transform.position + new Vector3(0, .01f, 0);
                StartCoroutine(Wait());
                audioSource.Stop();
            }
            Pressed = false;
        }
        else
        {
            /* if it's not pressed down */

        }
    }

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
    
	void Update () {
        if (Pressed)
        {
            if (pressable)
            {
                transform.position = transform.position + new Vector3(0, -.01f, 0);

                StartCoroutine(Wait());
                audioSource.Play();
                pressable = false;
            }
            else
            {
                transform.position = transform.position + new Vector3(0, .01f, 0);
                StartCoroutine(Wait());
                audioSource.Stop();
            }
            Pressed = false;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2.0f);
        pressable = true;
    }
}
