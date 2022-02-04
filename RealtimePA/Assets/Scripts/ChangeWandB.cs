using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWandB : MonoBehaviour
{
    public Material[] innenwand;
    public Material[] aussenwand;
    public MeshRenderer target;
    public Color[] colors;

    //Innenwand
    public void SetInnenwand(int i)
    {
        Material[] mats = target.materials;
        mats[1] = innenwand[i];
        target.materials = mats;
    }

    //F�r alle Au�enw�nde
    public void SetWand(int i)
    {
        foreach (Material m in aussenwand)
        {
            m.color = colors[i];
        }
    }
}
