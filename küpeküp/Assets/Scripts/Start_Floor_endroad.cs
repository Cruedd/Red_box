using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Floor_endroad : MonoBehaviour
{
    [SerializeField] Transform fr1,fr2, fr3, fr4, fr5;

    [SerializeField] GameObject gf1, gf2, gf3, gf4, gf5;
    bool ffexist = false;
    private void OnTriggerEnter(Collider Other)
    {

        if (Other.CompareTag("Player"))
        {
            int randomInt = Random.Range(0, 4);
            Debug.Log("Rastgele Tam Sayý: " + randomInt);
            Transform parentTransform = transform.parent;


            switch (randomInt)
            {
                case 0:
                    nextfloor(fr1, parentTransform);
                    gf1.active = true;
                    break;


                case 1:
                    nextfloor(fr2, parentTransform);
                    gf2.active = true;
                    break;
                case 2:
                    nextfloor(fr3, parentTransform);
                    gf3.active = true;
                    break;
                case 3:
                    nextfloor(fr4, parentTransform);
                    gf4.active = true;
                    break;
                case 4:
                    nextfloor(fr5, parentTransform);
                    gf5.active = true;
                    break;
            }




        }

    }

    private void nextfloor(Transform nf,Transform parentTransform)
    {

            nf.position = parentTransform.position + parentTransform.forward * 111;
            ffexist = true;
            Debug.Log("true yapýldý 173 ileri konuldu");

    }
}
