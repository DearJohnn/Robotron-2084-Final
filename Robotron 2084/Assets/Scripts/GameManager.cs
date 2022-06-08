using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int playerScore = 0;
    public static int HP = 10;
    public GUISkin layout;
    private GUIStyle guiStyle = new GUIStyle();
    public static void Score()
    {
        playerScore++;
    }
    public static void Health()
    {
        HP--;
    }
    private void OnGUI()
    {
        GUI.skin = layout;
        guiStyle.fontSize = 20;
        guiStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(Screen.width/2 + 150,20,100,100),"Score : " + playerScore,guiStyle);
        GUI.Label(new Rect(Screen.width / 2 - 150, 20, 100, 100), "HP : " + HP, guiStyle);
        if (GUI.Button(new Rect(Screen.width / 2 + 300, Screen.height - 50, 100, 40), "RESTART"))
        {
            HP = 10;
            playerScore = 0;
            PlayAgain();
        }
        if (HP <= 0)
        {
            GUI.Label(new Rect(Screen.width / 2 -30, Screen.height / 2, 100, 100), "YOU LOSE", guiStyle);
            GUI.Label(new Rect(Screen.width / 2 -100, Screen.height / 2 + 30, 100, 100), "PLEASE CLICK RESTART", guiStyle);
            Time.timeScale = 0;
        }

    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
