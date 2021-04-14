using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    Animator animatorController;

    private void Start()
    {
        animatorController = GetComponent<Animator>();
    }

    public void BackToMainMenu()
    {
        animatorController.SetBool("isOptionsMenuOpen", false);
    }

    public void OpenOptionsMenu()
    {
        animatorController.SetBool("isOptionsMenuOpen", true);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
