using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Vuforia;

public class ButtonHandler : MonoBehaviour
{
    public void restart()

    {
        VuforiaBehaviour.Instance.enabled = false;
       // void StopExtendedTracking()

            PositionalDeviceTracker extendedTracker = TrackerManager.Instance.GetTracker<PositionalDeviceTracker>();
            if (extendedTracker != null && extendedTracker.IsActive)
            {
                extendedTracker.Stop();
            }
        
        //void StopTracking()

            TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
        
        Task.Delay(2000).Wait();

        //void StartExtendedTracking()
        
            //PositionalDeviceTracker extendedTracker = TrackerManager.Instance.GetTracker<PositionalDeviceTracker>();
            if (extendedTracker != null && extendedTracker.IsActive)
            {
                extendedTracker.Start();
            }
        
        //void StartTracking()
        
            TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
        
        VuforiaBehaviour.Instance.enabled = true;
    }



}
