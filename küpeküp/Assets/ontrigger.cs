using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            Transform parentTransform = transform.parent; // Ebeveyn objenin Transform bileþenini al
            parentTransform.position += new Vector3(0, 0, 50);
        }
        
    }
}
