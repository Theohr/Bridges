using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToMedium : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeToMediumDiff()
    {
        SceneManager.LoadScene("MediumMode");
    }
}
