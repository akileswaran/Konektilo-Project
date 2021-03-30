using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityToggler : MonoBehaviour
{
    void Start()
    {
        GameObject modeltarget = GameObject.Find("ModelTarget");
        Component[] a = modeltarget.GetComponentsInChildren(typeof(Renderer));
        foreach (Component b in a)
        {
            Renderer c = (Renderer)b;
            c.enabled = false;
        }
    }

    public void DisplaySelectedItem(List<string> location)
    {
        #region disble_object
        //myGameObject = GameObject.Find("/ModelTarget/" + location);
        //myGameObject.SetActive(true);

        //foreach (string item in array)
        //{
        //    if (item != location)
        //    {
        //        var DisableGameObjects = GameObject.Find("/ModelTarget/" + item);
        //        DisableGameObjects.SetActive(false);
        //    }
        //}
        #endregion

        GameObject modeltarget = GameObject.Find("ModelTarget");
        Component[] a = modeltarget.GetComponentsInChildren(typeof(Renderer));
        foreach (Component b in a)
        {
            Renderer c = (Renderer)b;
            c.enabled = false;
        }
        foreach (var item in location)
        {
            //TextMesh textObject2 = GameObject.Find("rack7:").GetComponent<TextMesh>();
            //textObject2.text = "Box7:" + Convert.ToString(getResponse2);
            Renderer ObjectInLocation = GameObject.Find(item).GetComponent<Renderer>();
            ObjectInLocation.enabled = true;
            Renderer ObjectInLocation1 = GameObject.Find(item+".1").GetComponent<Renderer>();
            ObjectInLocation1.enabled = true;
        }
    }
}
