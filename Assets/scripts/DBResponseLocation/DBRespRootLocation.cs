using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBRespRootLocation : MonoBehaviour
{
    public int total_rows { get; set; }
    public int offset { get; set; }
    public List<DBRespRowLocation> rows { get; set; }
}
