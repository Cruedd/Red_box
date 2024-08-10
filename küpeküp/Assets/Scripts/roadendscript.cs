using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class roadendscript : MonoBehaviour
{
    [SerializeField] GameObject ParentObject;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            ParentObject.SetActive(false);
        }
    }
}
