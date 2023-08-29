using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput300 : MonoBehaviour
{
    public string string1;
    public int Int300;
    public Calculate clc;

    void Update()
    {
        Int300 = int.Parse(string1);
        if(clc.ChangeValue == true )
        {
            clc.n300 = Int300;
        }
        
    }

    public void ReadStringInput(string s)
    {
        string1 = s;
    }
}
