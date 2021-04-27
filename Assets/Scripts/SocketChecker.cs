using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SocketChecker : XRBaseInteractable
{
    private GameObject cap;
    public GameObject capDummy;
    public GameObject SnappedObject;
    public bool HatSnapped = false;
    public Vector3 preKillPos;

    void Awake()
    {
        XRSocketInteractor socket = gameObject.GetComponent<XRSocketInteractor>();

        //socket.onSelectEntered.AddListener(HatCheck);

        //socket.selectEntered.AddListener();

        cap = GameObject.FindGameObjectWithTag("BaseballHat");
        Debug.Log("socket from Awake: " + socket);
    }

  
    public void HatCheck(XRBaseInteractable obj)
    {
        if (obj.gameObject.CompareTag("BaseballHat"))
        {
            Debug.Log("Hat Snapped!");
            //Destroy(cap);
            SnappedObject = obj.gameObject;
            HatSnapped = true;
            Debug.Log("Snapped Object Initial ~~~" + gameObject);

        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Drill"))
    //    {
    //        Debug.Log("Drill hit Socket");
    //        Debug.Log("SnappedObject ===" + SnappedObject);
    //        //SnappedObject.transform.RotateAround(SnappedObject.transform.position, Vector3.up, 20 * Time.deltaTime);
    //        SnappedObject.gameObject.transform.Rotate(20.0f, 20.0f, 40.0f);
    //    }
    //}

    //
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Drill") && HatSnapped == true)
        {
            Debug.Log("Spinny?");
            Debug.Log("Le Snapped Object =======" + SnappedObject);
            //Debug.Log("SnappedObject ===" + SnappedObject);
            
            preKillPos = SnappedObject.transform.position;
            Destroy(SnappedObject);
            Instantiate(capDummy, preKillPos, Quaternion.identity);
           //transform.Rotate(120.0f, 20.0f, 40.0f);
        }
    }
}
