using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDoor : MonoBehaviour
{

    public Color[] colors;
    public MeshRenderer target;

    public void SetDoorColor(int i)
    {
        Material[] mats = target.materials;
        mats[1].color = colors[i];
        target.materials = mats;
    }
}
