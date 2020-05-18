using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    {
        // Restart the easy mode puzzle 
        SceneManager.LoadScene("EasyMode");   
    }
}
