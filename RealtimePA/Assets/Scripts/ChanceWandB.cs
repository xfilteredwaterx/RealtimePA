using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanceWandB : MonoBehaviour
{
    public Material[] innenwand;
    public Material[] au�enwand;
    public MeshRenderer target;
    public Color[] colors;

    //Innenwand
    public void SetObereWand(int i)
    {
        Material[] mats = target.materials;
        mats[1] = innenwand[i];
        target.materials = mats;
    }

    //F�r alle Au�enw�nde
    public void SetWand(int i)
    {
        foreach (Material m in au�enwand)
        {
            m.color = colors[i];
        }
    }
}
