using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBRespRootBoxname : MonoBehaviour
{
    public int total_rows { get; set; }
    public int offset { get; set; }
    public List<DBRespRowBoxname> rows { get; set; }
}
