using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class AnchorTest : MonoBehaviour
{
    ARAnchor _arAnchor;
    Material _material;
    // Start is called before the first frame update
    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        Invoke("AnchorObject", 5);
    }


    void AnchorObject()
    {
        _arAnchor = gameObject.AddComponent<ARAnchor>();

    }

    // Update is called once per frame
    void Update()
    {
        if(_arAnchor)
        {
            _material.color = _arAnchor.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking ? Color.green : Color.red;
        }
    }
}
