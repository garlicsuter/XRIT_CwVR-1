using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[System.Serializable]
public class Hat : MonoBehaviour
{
    public GameObject Socket1;
    public float myFloat = 0.09f;
    public SocketChecker script;

    // Start is called before the first frame update
    void Start()
    {
        script = Socket1.GetComponent<SocketChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        // THIS WORKS!
        //if (script.HatSnapped == true)
        //{
        //    transform.Rotate(10.0f, 10.0f, 10.0f);
        //}
        
    }

    //public void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.CompareTag("Drill") && script.HatSnapped == true)
    //    {
    //        Debug.Log("Drill hit HAAAATTTT");
    //        //Debug.Log("SnappedObject ===" + SnappedObject);
    //        //SnappedObject.transform.RotateAround(SnappedObject.transform.position, Vector3.up, 20 * Time.deltaTime);
    //        gameObject.transform.Rotate(20.0f, 20.0f, 40.0f);
    //    }
    //}
}
