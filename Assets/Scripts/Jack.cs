using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JackPosition
{
    public int X;
    public int Y;
}

public class Jack : MonoBehaviour
{
    public JackPosition _jackPosition;
    //private Board _boardScript;
    public GameObject greenlight;
    bool error;
    public Transform lockLocation;

    void Start()
    {
        //_jackPosition = new JackPosition();
        //_boardScript = GameObject.Find("Board").GetComponent<Board>();
        // Debug.Log(_boardScript);
    }
    private void Update()
    {

    }

    public void SetJackPosition(JackPosition jackPosition)
    {
        _jackPosition = jackPosition;
    }


    public void lightUp()
    {
        greenlight.SetActive(true);
    }

    public void lightOff()
    {
        greenlight.SetActive(false);
    }
    //    private void OnTriggerEnter(Collider other)
    //    {
    //        if(other.gameObject.tag.Equals("Plug"))
    //        {
    //            _boardScript.AddJackPosition(_jackPosition);
    //            Debug.Log("Plugging in!");
    //        }
    //    }

    //    private void OnTriggerExit(Collider other)
    //    {
    //        if (other.gameObject.tag.Equals("Plug"))
    //        {
    //            _boardScript.RemoveJackPosition(_jackPosition);
    //            Debug.Log("Pulling Out!");
    //        }
    //    }
}