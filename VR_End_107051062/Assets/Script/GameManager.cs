using UnityEngine;
using UnityEngine.SceneManagement;  
public class GameManager : MonoBehaviour
{
    
    public void RestartGame()
    {
        SceneManager.LoadScene("好友九宮格");
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
}