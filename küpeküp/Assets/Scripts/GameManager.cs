using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameover_menu;
    bool gamehasend = false;
    public float restartdelay = 1f;
    public GameObject complatelevelUI;
    
    public void CompleteLevel()
    {
        complatelevelUI.SetActive(true);
        Debug.Log("LEVEL WON!");
    }
    public void gameover()
    {

        if (gamehasend == false)
        {
            FindObjectOfType<PlayerMovement>().gameend();
            gamehasend = true;
            Debug.Log("GAME OVER");
            Invoke("menuopen", restartdelay);
        }

    }
     public void menuopen()
     {
        gameover_menu.SetActive(true );
     }

     public void Restart()
    {
        gameover_menu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
     public void followclose()
    {
        FindObjectOfType<FollowPlayer>().closee();
    }
    public void backtomenu()
    {
        Debug.Log("menüye dönülüyor");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
