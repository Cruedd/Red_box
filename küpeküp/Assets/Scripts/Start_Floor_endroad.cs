using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Floor_endroad : MonoBehaviour
{
    [SerializeField] Transform fr1, fr2, fr3, fr4, fr5, fr6;
    bool ffexist = false;
    private void OnTriggerEnter(Collider Other)
    {

        if (Other.CompareTag("Player"))
        {
            int randomInt = Random.Range(0, 5);
            Debug.Log("Rastgele Tam Sayý: " + randomInt);
            Transform parentTransform = transform.parent;
            switch (randomInt)
            {
                case 0:
                    nextfloor(fr1, parentTransform);
                    break;

                case 1:
                    nextfloor(fr2, parentTransform); break;
                case 2:
                    nextfloor(fr3, parentTransform); break;
                case 3:
                    nextfloor(fr4, parentTransform);
                    break;
                case 4:
                    nextfloor(fr5, parentTransform); break;
                case 5:
                    nextfloor(fr6, parentTransform); break;

            }




        }

    }

    private void nextfloor(Transform nf,Transform parentTransform)
    {

            nf.position = parentTransform.position + parentTransform.forward * 173;
            ffexist = true;
            Debug.Log("true yapýldý 173 ileri konuldu");

    }
}
