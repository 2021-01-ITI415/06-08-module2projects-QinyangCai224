using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBotton : MonoBehaviour
{
    public void backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
