using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBRespRow : MonoBehaviour
{
    public string id { get; set; }
    public string key { get; set; }
    public DBRespValue value { get; set; }
    public DBRespDoc doc { get; set; }
}
