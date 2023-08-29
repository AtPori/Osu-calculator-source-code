using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput0 : MonoBehaviour
{
    public string string1;
    public int Int0;
    public Calculate clc;

    void Update()
    {
        Int0 = int.Parse(string1);
        if (clc.ChangeValue == true)
        {
            clc.n0 = Int0;
        }
    }

    public void ReadStringInput(string s)
    {
        string1 = s;
    }
}
