using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlateau : MonoBehaviour
{
    public Material[] plasticMat;
    public Material[] stoneMat;
    public MeshRenderer target;

    public void SetPlasticMaterial(int i)
    {
        Material[] mats = target.materials;
        mats[0] = plasticMat[i];
        target.materials = mats;
    }

    public void SetStoneMaterial(int i)
    {
        Material[] mats = target.materials;
        mats[1] = stoneMat[i];
        target.materials = mats;
    }

}
