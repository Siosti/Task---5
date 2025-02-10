using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] Transform pos;

    public void Activate()
    {
        Instantiate(obj,pos.position,Quaternion.identity);
    }
}
