using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    bool closed = false;
    public Transform player;
    public float smoothSpeed = 0.1f;
    public Vector3 offset;
    public GameManager gameManager;
    void FixedUpdate()
    {
        if (player == null)
        {
            FindAnyObjectByType<GameManager>().gameover();
        }
        else
        {
            if (closed == false)
            {
                Vector3 desiredposition = player.position + offset;
                Vector3 smothedPosition = Vector3.Lerp(transform.position, desiredposition, smoothSpeed);
                transform.position = smothedPosition;

                Vector3 lookAtPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
                transform.LookAt(lookAtPosition);
            }
            
        }
    }
    public void closee()
    {
        closed = true;
    }

}
