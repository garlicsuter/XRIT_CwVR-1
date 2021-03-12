using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Vibrate2 : MonoBehaviour
{


    public XRBaseController xrbR;
    public XRBaseController xrbL;

    void Start()
    {
        
    }


    public void brrrpR()
    {

        xrbR.SendHapticImpulse(1.0f, 1.0f);
        Debug.Log("Brrrrrrrrrp RIIIIGHT");
    }

    public void brrrpL()
    {
        xrbL.SendHapticImpulse(1.0f, 1.0f);
        Debug.Log("Brrrrrrrrrp LEFFFFT");
    }
}
