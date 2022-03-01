using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private TextMesh End;

    public void Start()
    {
        gameObject.SetActive(false); 
    }
    public void EndGame()
    {
        gameObject.SetActive(true);
        Cursor.visible = true;
    }
    

    public void ButtonRetry()
    {
        SceneManager.LoadScene("SampleScene");
        print("The button is working");
    }
}
