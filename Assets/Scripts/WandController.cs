using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandController : MonoBehaviour {
    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

    private GameObject pickup;
	// Use this for initialization
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if(controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }

        if (controller.GetPressDown(gripButton))
        {
            if(pickup != null)
            {
                pickup.transform.parent = this.transform;
                pickup.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    
        if(controller.GetPressUp(gripButton))
        {
            if(pickup != null)
            {
                pickup.transform.parent = null;
                pickup.GetComponent<Rigidbody>().isKinematic = false;
            }
        }


    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals("PickableObject"))
        {
            pickup = collider.gameObject;
            Debug.Log("Picking up");
        }
    }

    public void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag.Equals("PickableObject"))
        {
            pickup = null;
        }
    }
}
