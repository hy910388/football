using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Startgame()
    {
        //���J����
        SceneManager.LoadScene(0);
    }
}
