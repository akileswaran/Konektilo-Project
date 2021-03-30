using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using System.Linq;
using Newtonsoft.Json;
using System.Reflection;

public class dropdown : MonoBehaviour
{
    string hardwareValue;
    string chuteIdList;
    public Dropdown dropdownVar;
    public GameObject myGameObject;
    RestCommunicaton CommObj = new RestCommunicaton();
    private List<string> names;
    private string getResponse1;
    private string getResponse2;
    private string getResponse3;
    VisibilityToggler Toggleobj = new VisibilityToggler();

    //private List<string> names = new List<string> {"1.1", "1.2", "1.3", "1.4", "2.1" };

    private void Start()
    {
        //CommObj.RestCall("https://jsonplaceholder.typicode.com/posts/1");
        //names = RootInfo.rows.Select(hardware => hardware.id).ToList();
        //Debug.Log(names);
        //PopulateList();
        CommObj.RestCall("http://141.60.104.55:5987/hardware_db/_all_docs?include_docs=true").Then(response =>
        {
            getResponse1 = response.Text;
            //Debug.Log(Convert.ToString(getResponse1));
            if (getResponse1 != null)
            {
                var DbResponseForHardwareId = JsonConvert.DeserializeObject<DBRespRoot>(getResponse1);
                Debug.Log("");

                names = DbResponseForHardwareId.rows.Select(hardware => hardware.id).ToList();
                Debug.Log(names);
                PopulateList();
                //TextMesh textObject = GameObject.Find("slot1").GetComponent<TextMesh>();
                //textObject.text = Convert.ToString(myDetails.total_rows);
            }

        });
    }

    public void Dropdown_IndexChanged(int index)
    {

        string NameString = names[index];
        List<string> BoxId = new List<string>();
        List<string> location = new List<string>();
    //location = new List<string>();
    //if (prop.Name.Contains("hardware"))
    //{
    //    // ?
    //    hardware.Add((string)prop.GetValue(row.doc, null));
    //}


    CommObj.RestCall("http://141.60.104.55:5987/chute_db/_all_docs?include_docs=true").Then(res =>
        {
            getResponse2 = res.Text;

            //if (getResponse2 != null)
            //{

                var DbResponseForChuteId = JsonConvert.DeserializeObject<DBRespRootBoxname>(getResponse2);


                foreach (var row in DbResponseForChuteId.rows)
                {
                    foreach (PropertyInfo prop in row.doc.GetType().GetProperties())
                    {
                        hardwareValue = (string)prop.GetValue(row.doc, null);
                        if (hardwareValue == NameString)
                        {
                            BoxId.Add(row.doc._id);
                            Debug.Log(hardwareValue);
                        }
                    if (prop.ToString() == "System.String hardware_10_id") break;

                    }
                }
            //}
            CommObj.RestCall("http://141.60.104.55:5987/br02/_all_docs?include_docs=true").Then(response =>
            {
                getResponse3 = response.Text;

                //if (getResponse3 != null)
                //{

                var DbResponseForLocation = JsonConvert.DeserializeObject<DBRespRootLocation>(getResponse3);
                //var chuteIdList = new List<string>();
                foreach (var row_loc in DbResponseForLocation.rows)
                {
                    if (row_loc.doc.chute_ids.Count > 0)
                    {
                        chuteIdList = row_loc.doc.chute_ids[0];
                    }
                    else
                    { chuteIdList = "empty"; }


                    foreach (var item2 in BoxId)
                    {
                        if (chuteIdList == item2)
                        {
                            location.Add(row_loc.doc._id);
                        }

                    }
                    if (chuteIdList == "RK3109_BR02_R03_F94") break;
                }
                //}
                Toggleobj.DisplaySelectedItem(location);
            });
        });





    }

    void PopulateList()
    {
        dropdownVar.AddOptions(names);
    }


}
