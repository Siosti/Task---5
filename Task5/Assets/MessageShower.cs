using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageShower : MonoBehaviour
{
    [SerializeField] GameObject Text;

    public void ShowText()
    {
        Text.SetActive(true);
    }

    public void HideText()
    {
        Text.SetActive(false);
    }

}
