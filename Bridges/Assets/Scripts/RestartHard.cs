using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartHard : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartHardMode()
    {
        SceneManager.LoadScene("HardMode");
    }
}
