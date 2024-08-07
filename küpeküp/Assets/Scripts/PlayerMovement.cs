using UnityEngine;
using UnityEngine.UIElements;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameManager gameManager;
    public Rigidbody rb;
    public float fowardforce = 600f;
    public float sidewayforce = 100f;
    public bool ded = false;
    public Vector3 y�n;

    public Transform Player;
    public float olmas�gereken = 5f;
    public float bozukoldugundaneminolma = 5f;
    public float time = 0f;
    public void gameend()
    {

        ded = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float playerkordinaty = Player.rotation.y;
        float playerkordinatz = Player.rotation.z;
        float playerkordinatx = Player.rotation.x;


        if (!ded) 
        { 
            rb.AddForce(0, 0, fowardforce * Time.deltaTime);
        }




        if (Input.GetKey("d") && !ded)
        {
            rb.AddForce(sidewayforce * Time.deltaTime , 0, 0  , ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")  && !ded)
        {
            rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0  , ForceMode.VelocityChange);
        }
        if (rb.position.y < -0.2f)
        {
            ded = true;
            FindAnyObjectByType<GameManager>().followclose();
        }
        if (rb.position.y < -1f)
        {
            
            FindAnyObjectByType<GameManager>().gameover();
        }


        if (playerkordinaty < -olmas�gereken || playerkordinaty < olmas�gereken)
        {
            time += Time.deltaTime;
            //Invoke("Pozistyond�zeltme", bozukoldugundaneminolma);
            if (time > bozukoldugundaneminolma)
            {

            }

        }


    }

    public void Pozistyond�zeltme()
    {
        Debug.Log("Nesne A'n�n X koordinat� -5'in alt�nda! Eylem ger�ekle�tiriliyor...");

        // �rnek olarak nesneyi hareket ettirme veya ba�ka bir eylem yapma
        Player.DORotate(new Vector3(0, 0, 0),1);
    }
}
