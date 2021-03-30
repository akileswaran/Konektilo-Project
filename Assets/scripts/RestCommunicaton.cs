using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
using UnityEditor;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

public class RestCommunicaton : MonoBehaviour
{
    private string getResponse1;

    void Update()
    {
        int i = 0;
        while (i < 10000)
        {
            i++;
        }

        #region previous code
        //var box7 = RestClient.Get("http://localhost:8080/api/v1/server/opcuatestserver/namespace/2/identifier/Demo.Massfolder_Static.Variable0003").Then(res => getResponse2 = res.Text);
        //Debug.Log(getResponse2);

        //if (getResponse2 != null)
        //{
        //    TextMesh textObject2 = GameObject.Find("rack7:").GetComponent<TextMesh>();
        //    textObject2.text = "Box7:" + Convert.ToString(getResponse2);
        //    //textObject2.text = "Box7:" + "167";
        //}


        //RestClient.Put("http://localhost:8080/api/v1/server/opcuatestserver/namespace/2/identifier/Demo.Static.Scalar.String", new postInformation { variableData="appa" }).Then(res => {return "Ok"; });
        #endregion
    }
    public RSG.IPromise<ResponseHelper> RestCall(string BaseUrl)
    {
        var currentRequest = new RequestHelper
        {
            Uri = BaseUrl,
            Headers = new Dictionary<string, string> {
            { "Authorization", "Basic cHJvdG9sYWJyZWFkOjJFdC1ZQXAhZ0RqXQ==" }
            }
        };

        #region comment
        //Debug.Log(BaseUrl); //https://jsonplaceholder.typicode.com/posts/1

        //RestClient.Get(currentRequest).Then(res =>
        //{
        //    getResponse1 = res.Text;
        //    //Debug.Log(Convert.ToString(getResponse1));
        //    if (getResponse1 != null)
        //    {
        //        var DbResponse = JsonConvert.DeserializeObject<DBRespRoot>(getResponse1);
        //        Debug.Log("");
        //        //TextMesh textObject = GameObject.Find("slot1").GetComponent<TextMesh>();
        //        //textObject.text = Convert.ToString(myDetails.total_rows);
        //    }

        //});
        #endregion
        return RestClient.Get(currentRequest);
        
        //var test = Task.Run(async () =>
       //{
       //    await RestClient.Get(currentRequest);
       //});


    }
}
