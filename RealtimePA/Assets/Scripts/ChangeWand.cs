using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWand : MonoBehaviour
{

    public Material[] tapete;
    public Material[] aussenwand;
    public MeshRenderer target;
    public Color[] colors;

    public void SetObereWand(int i)
    {
        Material[] mats = target.materials;
        mats[2] = tapete[i];
        target.materials = mats;
    }


    public void SetWand(int i)
    {
        foreach (Material m in aussenwand)
        {
            m.color = colors[i];
        }
    }
}
