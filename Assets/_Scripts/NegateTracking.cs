using UnityEngine;
using UnityEngine.VR;

public class NegateTracking : MonoBehaviour {

    public GameObject cameraObject;
    public Transform hotSpotSpindleTransform;
    public Transform hotSpotOperatorTransform;

    public bool spindleScene = false;
    public bool operatorScene = false;

    private Camera cam;
    private Vector3 currentPos;

    private void Start()
    {
        cam = cameraObject.GetComponent<Camera>();
    }

    void Update () {
        
        transform.rotation = Quaternion.Inverse(UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.CenterEye));

        if (spindleScene)
        {
            Quaternion targetRot = Quaternion.Euler(5f, -77f, 0f);
            cam.transform.rotation = targetRot;
        }

        if (operatorScene)
        {
            Quaternion targetRot = Quaternion.Euler(5f, -150f, 0f);
            cam.transform.rotation = targetRot;
        }


    }

}
