using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionController : MonoBehaviour
{
   [SerializeField] UnityEvent EnterAction;
   [SerializeField] UnityEvent LeaveAction;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Stuff"))
        {
            EnterAction?.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Stuff"))
        {
            LeaveAction?.Invoke();
        }
    }
}
