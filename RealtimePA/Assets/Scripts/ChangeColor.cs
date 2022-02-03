using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
   /* public Material[] materials; */
    public MeshRenderer target;
    public Color[] colors;

    public void SetTarget (MeshRenderer target)
    {
        this.target = target;
    }

    public void SetColor(Material m)
    {
        target.material = m;
    }

    public void SetColor(int i)
    {
        target.material.color = colors[i] ;
    }

}
