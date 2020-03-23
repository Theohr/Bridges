using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToMain : MonoBehaviour
{
    // Change to Main Scene
    public void ChangeToMainScene()
    {
        SceneManager.LoadScene("HomePage");
    }
}
