//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using TMPro;
//using UnityEngine.UI;
//using System;
//using Proyecto26;
//using Newtonsoft.Json;

//public class testscript : MonoBehaviour
//{
//    public Dropdown dropdownVar;
//    public GameObject myGameObject;
//    RestCommunicaton CommObj = new RestCommunicaton();
//    private string getResponse1;

//    public void Dropdown_IndexChanged(int index)
//    {

//        //string NameString = names[index];
//        TestRoot array = new TestRoot();
//        List<string> list = array.MyArray.;
//        string NameString = list[index];
//        VisibilityToggler Toggleobj = new VisibilityToggler();
//        Toggleobj.DisplaySelectedItem(NameString);




//    }
//    // Start is called before the first frame update
//    void Start()
//    {
//        var box7 = RestClient.Get("https://jsonplaceholder.typicode.com/posts/1").Then(res =>
//        {
//            getResponse1 = res.Text;
//        });
//        PopulateList();
//    }
//    void PopulateList()
//    {
//        dropdownVar.AddOptions(list);
//    }
//}
