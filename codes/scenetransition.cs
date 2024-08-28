using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetransition : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            // Starting the game with 'SPACE'
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key pressed");
                SceneManager.LoadScene("MainScene");
            }
        }

        if (SceneManager.GetActiveScene().name == "DeathScene")
        {
            // Restarting the game with 'SPACE'
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key pressed");
                SceneManager.LoadScene("MainScene");
            }
        }

        if (SceneManager.GetActiveScene().name == "EndScene")
        {
            // Restarting the game with 'SPACE'
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key pressed");
                SceneManager.LoadScene("StartScene");
            }
        }
    }
}