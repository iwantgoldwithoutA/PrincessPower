using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int princetext = 1;
    [SerializeField] private Text PrincessText;
    public AskAgain AskAgain;

    public void PlayThisGame()
    {
        AskAgain.Setup();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void TouchPrincess()
    {
        princetext += 1;
        if (princetext==2){
            PrincessText.text = "HEY! STOP";
        }
        if (princetext==3){
            PrincessText.text = "I TOLD YOU TO STOP!";
        }
        if (princetext==4){
            PrincessText.text = "THIS IS THE LAST WARNING";
        }
        if (princetext==5){
            SceneManager.LoadScene("TouchPrinceScene");
        }
    }
}
