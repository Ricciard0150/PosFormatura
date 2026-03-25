using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
   public void Loading1()
    {
        SceneManager.LoadScene("Game");
    }
    public void goBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
