using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject[] animatedImages;
    void Update () {
        if (animatedImages.Length > 0) {
            foreach (GameObject animatedImage in animatedImages) {
                animatedImage.transform.Rotate(0, 0, 1);
            }
        }


    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
