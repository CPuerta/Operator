using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickFormat : MonoBehaviour {
    public int width;
    public int height;
    public float spacing= 1.5f;
     Board b;
	// Use this for initialization
	void Awake () {
        b = this.GetComponent<Board>();
        b.jacks = new Jack[8, 4];

        for (int i = 0; i < 4; i++)
        {
            transform.GetChild(i).transform.localPosition = new Vector3(i * spacing, 0, 0);
            transform.GetChild(i).transform.name = "y" + i;

            for (int j = 0; j < 8; j++)
            {
                GameObject JAckhole= transform.GetChild(i).transform.GetChild(j).gameObject;
                JAckhole.transform.localPosition = new Vector3(0,0 , j * spacing);// can probably instiate instead 
                JAckhole.transform.name ="y"+i+ "x" + j;
                JAckhole.gameObject.tag = "Incorrect";
                //transform.GetChild(i).transform.GetChild(j).gameObject.GetComponent<BoxCollider>().isTrigger = true;
                var jack = transform.GetChild(i).transform.GetChild(j).gameObject.AddComponent<Jack>();
                jack._jackPosition = new JackPosition();
                jack._jackPosition.X = j;
                jack._jackPosition.Y = i;
                jack.greenlight = JAckhole.transform.GetChild(1).gameObject;
                jack.greenlight.SetActive(false);
                jack.lockLocation = JAckhole.transform.GetChild(2);
                b.AddJack(jack);
            }
        }
        //Destroy(transform.GetChild(4).gameObject);
        //Destroy(transform.GetChild(5).gameObject);
        //Destroy(transform.GetChild(6).gameObject)
        //Destroy(transform.GetChild(7).gameObject);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
