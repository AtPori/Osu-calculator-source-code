using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput50 : MonoBehaviour
{
    public string string1;
    public int Int50;
    public Calculate clc;

    void Update()
    {
        Int50 = int.Parse(string1);
        if (clc.ChangeValue == true)
        {
            clc.n50 = Int50;
        }
    }

    public void ReadStringInput(string s)
    {
        string1 = s;
    }
}
