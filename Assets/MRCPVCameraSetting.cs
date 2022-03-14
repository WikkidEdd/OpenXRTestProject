using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MRCPVCameraSetting : MonoBehaviour
{
    public bool _Enable;

    // Start is called before the first frame update
    void Start()
    {
#if WINDOWS_UWP

        Debug.Log("Attempting to Apply PV Camera setting for MRC");
        // If the default display has configuration for a PhotoVideoCamera, we want to enable it
        global::Windows.Graphics.Holographic.HolographicViewConfiguration viewConfiguration = global::Windows.Graphics.Holographic.HolographicDisplay.GetDefault()?.TryGetViewConfiguration(global::Windows.Graphics.Holographic.HolographicViewConfigurationKind.PhotoVideoCamera);
                
        if (viewConfiguration != null)
        {
            Debug.Log("Setting viewConfiguration.IsEnabled to " + _Enable);
            viewConfiguration.IsEnabled = _Enable;
        }

#endif // WINDOWS_UWP
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
