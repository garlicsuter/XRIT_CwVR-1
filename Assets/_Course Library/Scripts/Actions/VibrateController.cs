using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Vibrate the XR Controller
/// </summary>
public class VibrateController : MonoBehaviour
{
    public float strongVibrate = 0.75f;
    public float weakVibrate = 0.25f;

    public XRController controller;

    public void Awake()
    {
        //controller = GetComponent<XRController>();

        //GameObject ctrlR = GameObject.FindWithTag("CtrlR");

        //if (ctrlR != null)
        //{
        //    controller = ctrlR.GetComponent<XRController>();
        //    Debug.Log("Found right ctrl");
        //}
    }

   

    public void Vibrate(float amplitude, float duration)
    {
        // OpenVR currently only supports amplitude
        controller.SendHapticImpulse(amplitude, duration);
    }

    public void VibrateWeak(float duration)
    {
        controller.SendHapticImpulse(weakVibrate, duration);
    }

    public void VibrateStrong(float duration)
    {
        controller.SendHapticImpulse(strongVibrate, duration);
        Debug.Log("Called VibrateStrong");
    }

  

    public void DebugMe1()
    {
        Debug.Log("You debugged 1");
    }

    public void DebugMe2()
    {
        Debug.Log("You debugged 2");
    }

    public void DebugMe3()
    {
        Debug.Log("You debugged 3");
    }
}
