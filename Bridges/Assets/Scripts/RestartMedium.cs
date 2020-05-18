using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMedium : MonoBehaviour
{
    // Restart the medium mode puzzle
    public void RestartMediumMode()
    {
        SceneManager.LoadScene("MediumMode");
    }
}
