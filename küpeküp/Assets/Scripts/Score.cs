
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    private bool playerAlive = true;
    // Update is called once per frame
    void Update()
    {

        if (playerAlive && Player != null)
        {
            ScoreText.text = Player.position.z.ToString("0");
        }

    }
}
