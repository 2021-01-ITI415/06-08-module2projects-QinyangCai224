using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScripts : MonoBehaviour
{
    public void selectSene() {
        switch (this.gameObject.name) {
        case"__Prospector_Scene_0Button":
                SceneManager.LoadScene("__Prospector_Scene_0");
            break;
        case "MyGameButton":
                SceneManager.LoadScene("MyGame");
            break;
    }

}

    }
