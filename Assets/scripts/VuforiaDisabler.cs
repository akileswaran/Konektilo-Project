using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class VuforiaDisabler : MonoBehaviour
{
    // Start is called before the first frame update
    public void DisableVuforia()
    {
        //VuforiaBehaviour.Instance.enabled = false;
        SceneManager.LoadScene("SampleScene");
    }

}
