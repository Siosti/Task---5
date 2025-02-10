using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] public int cost;

    private void Update()
    {
        transform.Rotate(0,1,0);
    }
    public void OnPickUp()
    {
        Destroy(gameObject);
    }
}
