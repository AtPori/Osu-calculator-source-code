using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public float n300;
    public float n100;
    public float n50;
    public float n0;
    public Text Accuracy;
    public float percent;
    public bool ChangeValue = true;

    public void VoidCalculate()
    {
        StartCoroutine(calculate());
    }

    public IEnumerator calculate()
    {
        //calculate
        ChangeValue = false;
        percent = ((((300 * n300) + (100 * n100) + (50 * n50) + (0 * n0)) / ((n300 + n100 + n50 + n0) * 300)) * 100);
        yield return new WaitForSeconds(0.0001f);
        Accuracy.text = percent.ToString("F2");
        Accuracy.text = (percent.ToString("F2") + "%");
        ChangeValue = true;
        //text = 
    }
}
