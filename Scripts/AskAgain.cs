using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AskAgain : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }
   
    public void PlayGame()
    {
        SceneManager.LoadScene("FirstStartScene");
    }
}
