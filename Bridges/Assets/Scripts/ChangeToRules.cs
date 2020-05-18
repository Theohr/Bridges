using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToRules : MonoBehaviour
{
    // Takes the user to the rules scene
    public void ChangeToRulesInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
