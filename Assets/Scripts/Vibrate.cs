using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Vibrate : MonoBehaviour
{

    //public XRController xr;
    //public InputHelpers.Button activateUsage { get; set; }
    public XRBaseController xrbR;
    public XRBaseController xrbL;
    private bool readyLeft = false;
    private bool readyRight = false;


    //void OnCollisionStay(Collision other)
    //{
    //    if (other.gameObject.CompareTag("Drill") && OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) == 1)
    //    {
    //        Debug.Log("triggered Drill RIGHT " + OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger));
    //        readyRight = true;
    //        brrrpR();
    //    }

    //    if (other.gameObject.CompareTag("Drill") && OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) == 1)
    //    {
    //        Debug.Log("triggered Drill LEFT " + OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger));
    //        readyLeft = true;
    //        brrrpL();
    //    }


    //if (other.gameObject.CompareTag("CtrlL"))
    //{
    //    brrrpL();
    //}

    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CtrlR")){
            Debug.Log("Enter RIGHT");
            readyRight = true;
            //readyLeft = false;
        }

        if (other.gameObject.CompareTag("CtrlL"))
        {
            Debug.Log("Enter LEFT");
            readyLeft = true;
            //readyRight = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("CtrlR"))
        {
            Debug.Log("Exit RIGHT");
            readyRight = false;
            
        }

        if (other.gameObject.CompareTag("CtrlL"))
        {
            Debug.Log("Exit LEFT");
            readyLeft = false;
        }
    }


    public void brrrpR()
    {
        if(readyRight == true)
        {
            xrbR.SendHapticImpulse(1.0f, 1.0f);
            Debug.Log("Brrrrrrrrrp RIIIIGHT");
        }
    }

    public void brrrpL()
    {
        if(readyLeft == true)
        {
            xrbL.SendHapticImpulse(1.0f, 1.0f);
            Debug.Log("Brrrrrrrrrp LEFFFFT");
        }      
    }
}
