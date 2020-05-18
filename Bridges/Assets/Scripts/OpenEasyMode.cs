using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenEasyMode : MonoBehaviour
{
    // Takjes the user to the easy puzzle
    public void ChangeToEasyDiff()
    {
        SceneManager.LoadScene("EasyMode");
    }
}
