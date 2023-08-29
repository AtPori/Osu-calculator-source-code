using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput100 : MonoBehaviour
{
    public string string1;
    public int Int100;
    public Calculate clc;

    void Update()
    {
        Int100 = int.Parse(string1);
        if (clc.ChangeValue == true)
        {
            clc.n100 = Int100;
        }
    }

    public void ReadStringInput(string s)
    {
        string1 = s;
    }
}
