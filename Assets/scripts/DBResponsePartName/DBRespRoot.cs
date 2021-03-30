using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBRespRoot : MonoBehaviour
{
    public int total_rows { get; set; }
    public int offset { get; set; }
    public List<DBRespRow> rows { get; set; }

}
