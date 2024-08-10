using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontrigger : MonoBehaviour
{
    [SerializeField] Transform fr1, fr2, fr3, fr4, fr5, fr6;
    [SerializeField] GameObject fro1, fro2, fro3, fro4, fro5, fro6;
    private void OnTriggerEnter(Collider Other)
    {

        if (Other.CompareTag("Player"))
        {
            int randomInt = Random.Range(0, 5);
            Debug.Log("Rastgele Tam Sayý: " + randomInt);
            Transform parentTransform = transform.parent; // Ebeveyn objenin Transform bileþenini al
            switch (randomInt)
            {

                case 0:
                    if(fro1.active == false)
                    {
                        fro1.SetActive(true);
                        nextfloor(fr1, parentTransform);
                    }
                    else
                    {
                        return;
                    }
                    break;


                case 1:
                    if (fro2.active == false)
                    {
                        fro2.SetActive(true);
                        nextfloor(fr2, parentTransform);
                    }
                    else
                    {
                        return;
                    }
                    break;

                case 2:
                    if (fro3.active == false)
                    {
                        fro3.SetActive(true);
                        nextfloor(fr3, parentTransform);
                    }
                    else
                    {
                        return;
                    }
                    break;
                case 3:
                    if (fro4.active == false)
                    {
                        fro1.SetActive(true);
                        nextfloor(fr4, parentTransform);
                    }
                    else
                    {
                        return;
                    }
                    break;

                case 4:
                    if (fro5.active == false)
                    {
                        fro1.SetActive(true);
                        nextfloor(fr5, parentTransform);
                    }
                    else
                    {
                        return;
                    }
                    break;
                case 5:
                    if (fro6.active == false)
                    {
                        fro1.SetActive(true);
                        nextfloor(fr6, parentTransform);
                    }
                    else
                    {
                        return;
                    }
                    break;
            }




        }

    }

    private void nextfloor(Transform nf,Transform parentTransform)
    {

        nf.position = parentTransform.position + parentTransform.forward * 100;
    }
}
