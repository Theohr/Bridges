using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToRules : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeToRulesInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
