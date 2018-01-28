using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriefingRoomEndGame : MonoBehaviour {
    public float timeb4Spawn;
    // Use this for initialization
    public GameObject TypeCollection;
	void Start () {
        StartCoroutine(wait());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator wait()
    {
        yield return new WaitForSeconds(timeb4Spawn);
        TypeCollection.SetActive(true);

    }

    //load to next scene funtion
}
