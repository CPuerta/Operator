using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandController : MonoBehaviour
{
    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

    public GameObject pickup;
    // Use this for initialization
    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }

        if (controller.GetPress(triggerButton))
        {
            if (pickup != null)
            {
                pickup.transform.parent = this.transform;
                //pickup.GetComponent<Rigidbody>().isKinematic = true;
                if (pickup.GetComponent<Plug>())
                {
                    pickup.GetComponent<Plug>().HELD = true;

                }

            }
        }

        if (controller.GetPressUp(triggerButton))
        {
            if (pickup != null)
            {
                if (pickup.GetComponent<Plug>())
                {
                    pickup.GetComponent<Plug>().HELD = false;

                }
                pickup.transform.parent = null;

                //pickup.GetComponent<Rigidbody>().isKinematic = false;
            }
            pickup = null;
        }


    }

    private void OnTriggerStay(Collider collider)
    {
        if (pickup == null)
        {
            if (collider.gameObject.tag.Equals("PickableObject"))
            {
                pickup = collider.gameObject;

            }
        }

    }

    public void OnTriggerExit(Collider collider)
    {
        if (pickup != null)
        {
            if (collider.gameObject.tag.Equals("PickableObject"))
            {
                pickup = null;

            }
        }

    }
}