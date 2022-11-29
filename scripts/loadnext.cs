using UnityEngine;
using UnityEngine.SceneManagement;
public class loadnext : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
}
