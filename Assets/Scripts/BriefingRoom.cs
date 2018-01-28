using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BriefingRoom : MonoBehaviour {
    public float timeb4Spawn;
    public AudioSource AS;
    public int level;
    // Use this for initialization
    public GameObject TypeCollection;
	void Start () {
        AS = this.GetComponent<AudioSource>();
        StartCoroutine(wait());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator wait()
    {
        yield return new WaitForSeconds(timeb4Spawn);
        TypeCollection.SetActive(true);
        AS.Play();
    }
    public void loadNext() {

        StartCoroutine(wait2load());
    }
    IEnumerator wait2load()
    {
        yield return new WaitForSeconds(timeb4Spawn/2);
        SceneManager.LoadScene(level);
    }
    //load to next scene funtion
}
