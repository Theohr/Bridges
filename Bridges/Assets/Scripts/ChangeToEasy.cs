using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenEasyMode : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeToEasyDiff()
    {
        SceneManager.LoadScene("EasyMode");
    }
}
