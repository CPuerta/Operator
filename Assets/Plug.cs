using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plug : MonoBehaviour
{

    public Jack currentJack;
    public int x;
    public int y;
    public bool HELD = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void error()
    {
        currentJack = null;
        HELD = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Jack>())
        {
            if (!HELD && currentJack != other.GetComponent<Jack>())
            {

                print("Plugged in");
                currentJack = other.GetComponent<Jack>();
                x = currentJack._jackPosition.X;
                y = currentJack._jackPosition.Y;
                this.transform.position = currentJack.lockLocation.position;
                this.transform.rotation = currentJack.lockLocation.rotation;
                //position code
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Jack>() && currentJack != null)
        {
            print("Unplugged");
            currentJack = null;
        }
    }
}
