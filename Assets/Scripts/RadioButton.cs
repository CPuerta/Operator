using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton : MonoBehaviour {
    public bool Pressed;
    bool pressable = true;
    public audio_Randomizer AS;
    
    private void OnTriggerEnter(Collider other)
    {

        if (!Pressed)
        {
            if (pressable)
            {
                transform.position = transform.position + new Vector3(0, -.01f, 0);
                StartCoroutine(Wait());
                AS.audioSource.mute = !AS.audioSource.mute;

                pressable = false;
                Pressed = true;

            }
            else
            {
                
            }
        }
        else
        {
            if (pressable)
            {
                transform.position = transform.position + new Vector3(0, .01f, 0);
                StartCoroutine(Wait());
                Pressed = false;

                AS.audioSource.mute = !AS.audioSource.mute;
            }
           
        }
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
    
	//void Update () {
 //       if (Pressed)
 //       {
 //           if (pressable)
 //           {
 //               transform.position = transform.position + new Vector3(0, -.01f, 0);

 //               StartCoroutine(Wait());
 //               //AS.Play();
 //               pressable = false;
 //           }
 //           else
 //           {
 //               transform.position = transform.position + new Vector3(0, .01f, 0);
 //               StartCoroutine(Wait());
 //              // AS.Stop();
 //           }
 //           Pressed = false;
 //       }
 //   }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2.0f);
        pressable = true;
    }
}
