using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AlarmFase
{
    public int code;
    public string location;
    public string floor;

    public AlarmFase(int cd, string loc)
    {
        this.code = cd;
        this.location = loc;
    }
    
    public AlarmFase(int cd, string loc, string flo)
    {
        this.code = cd;
        this.location = loc;
        this.floor = flo;
    }
}
