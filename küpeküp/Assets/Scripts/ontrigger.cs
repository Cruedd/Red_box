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

            Transform parentTransform = transform.parent; // Ebeveyn objenin Transform bile�enini al

            while(true)
            {
                int randomInt = Random.Range(0, 5);
                Debug.Log("Rastgele Tam Say�: " + randomInt);
                switch (randomInt)
                {

                    case 0:
                        if (fro1.active == false)
                        {
                            Debug.Log("fr1 ca�r�ld�");
                            fro1.SetActive(true);
                            nextfloor(fr1, parentTransform);
                            return;
                        }

                        break;


                    case 1:
                        if (fro2.active == false)
                        {
                            Debug.Log("fr2 ca�r�ld�");
                            fro2.SetActive(true);
                            nextfloor(fr2, parentTransform);
                            return;
                        }

                        break;

                    case 2:
                        if (fro3.active == false)
                        {
                            Debug.Log("fr3 ca�r�ld�");
                            fro3.SetActive(true);
                            nextfloor(fr3, parentTransform);
                            return;
                        }

                        break;
                    case 3:
                        if (fro4.active == false)
                        {
                            Debug.Log("fr4 ca�r�ld�");
                            fro4.SetActive(true);
                            nextfloor(fr4, parentTransform);
                            return;
                        }

                        break;

                    case 4:
                        if (fro5.active == false)
                        {
                            Debug.Log("fr5 ca�r�ld�");
                            fro5.SetActive(true);
                            nextfloor(fr5, parentTransform);
                            return;
                        }

                        break;
                    case 5:
                        if (fro6.active == false)
                        {
                            Debug.Log("fr1 ca�r�ld�");
                            fro6.SetActive(true);
                            nextfloor(fr6, parentTransform);
                            return;
                        }
                        break;
                }
            }





        }

    }

    private void nextfloor(Transform nf,Transform parentTransform)
    {

        nf.position = parentTransform.position + parentTransform.forward * 100;
    }
}
