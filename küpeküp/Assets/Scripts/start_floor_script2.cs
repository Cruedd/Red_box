using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_floor_script2 : MonoBehaviour
{
    [SerializeField] Transform  fr2;
    private void OnTriggerEnter(Collider Other)
    {

        if (Other.CompareTag("Player"))
        {
            Transform parentTransform = transform.parent;

            fr2.position = parentTransform.position + parentTransform.forward * 61;



        }

    }

}
