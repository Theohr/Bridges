using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartHard : MonoBehaviour
{
    // Restart the hard mode puzzle
    public void RestartHardMode()
    {
        SceneManager.LoadScene("HardMode");
    }
}
