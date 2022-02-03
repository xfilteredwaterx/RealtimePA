using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWand : MonoBehaviour
{

    public Material[] tapete;
    public Material[] au�enwand;
    public Material[] wood;
    public MeshRenderer target;
    public Color[] colors;

    public void SetObereWand(int i)
    {
        Material[] mats = target.materials;
        mats[2] = tapete[i];
        target.materials = mats;
    }

    public void SetUntereWand(int i)
    {
        Material[] mats = target.materials;
        mats[1] = wood[i];
        target.materials = mats;
    }

    public void SetWand(int i)
    {
        foreach (Material m in au�enwand)
        {
            m.color = colors[i];
        }
    }
}
