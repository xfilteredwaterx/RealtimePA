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

    //Für alle Außenwände
    public void SetWand(int i)
    {
        Material[] mats = target.materials;
        mats[0].color = colors[i];
        target.materials = mats;
    }
}
