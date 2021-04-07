using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SocketChecker : XRBaseInteractable
{
    private GameObject cap;

    void Awake()
    {
        XRSocketInteractor socket = gameObject.GetComponent<XRSocketInteractor>();
        //socket.onSelectEntered.AddListener(HatCheck);

        cap = GameObject.FindGameObjectWithTag("BaseballHat");
        Debug.Log("socket from Awake: " + socket);
    }

    public void HatCheck(XRBaseInteractable obj)
    {
        if (obj.gameObject.CompareTag("BaseballHat"))
        {
            Debug.Log("Destroy baseball hat!");
            Destroy(cap);
            
        }
    }
}
