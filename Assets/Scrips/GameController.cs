using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject Player;
    
  
    public void EndGame()
    {
        Debug.Log("GameOver");
        Destroy(Player);
        Reset();
    }
    public void Reset()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void NextLevel()
    {
        Debug.Log("Pasaste");
        Destroy(Player);
        Next();
    }
    public void Next()
    {
        SceneManager.LoadScene("Segundo_Level");
    }
    public void winlevel()
    {
        Debug.Log("Ganaste");
        Destroy(Player);
        win();
    }
    public void win()
    {
        SceneManager.LoadScene("Win");
    }
}

