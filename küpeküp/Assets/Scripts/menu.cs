using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public void quit()
    {
        Debug.Log("quiting");
        Application.Quit();
    }
    public void Startý()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
