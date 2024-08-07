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
    public Vector3 yön;

    public Transform Player;
    public float olmasýgereken = 5f;
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


        if (playerkordinaty < -olmasýgereken || playerkordinaty < olmasýgereken)
        {
            time += Time.deltaTime;
            //Invoke("Pozistyondüzeltme", bozukoldugundaneminolma);
            if (time > bozukoldugundaneminolma)
            {

            }

        }


    }

    public void Pozistyondüzeltme()
    {
        Debug.Log("Nesne A'nýn X koordinatý -5'in altýnda! Eylem gerçekleþtiriliyor...");

        // Örnek olarak nesneyi hareket ettirme veya baþka bir eylem yapma
        Player.DORotate(new Vector3(0, 0, 0),1);
    }
}
