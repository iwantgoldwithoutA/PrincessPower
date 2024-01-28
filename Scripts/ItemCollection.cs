using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemCollection : MonoBehaviour
{

    public TextMeshProUGUI text;
    private int Score;


    public static ItemCollection instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    public void addCherry() 
    {
        Score++;
        text.text = Score.ToString();
    }
}
