using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickFormat : MonoBehaviour {
    public int width;
    public int height;
    public float spacing= 1.5f;

	// Use this for initialization
	void Awake () {
        for (int i = 0; i < width; i++)
        {
            transform.GetChild(i).transform.localPosition = new Vector3(i * spacing, 0, 0);
            transform.GetChild(i).transform.name = "y" + i;
            for (int j = 0; j < height; j++)
            {

                transform.GetChild(i).transform.GetChild(j).transform.localPosition = new Vector3(0,0 , j * spacing);// can probably instiate instead 
                transform.GetChild(i).transform.GetChild(j).transform.name ="y"+i+ "x" + j;
                transform.GetChild(i).transform.GetChild(j).gameObject.tag = "Incorrect";
                var jack = transform.GetChild(i).transform.GetChild(j).GetComponent<Jack>();
                jack._jackPosition.X = j;
                jack._jackPosition.Y = i;
            }
        }
        Destroy(transform.GetChild(5).gameObject);
        Destroy(transform.GetChild(6).gameObject);
        Destroy(transform.GetChild(7).gameObject);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
