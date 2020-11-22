using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayAdventure () 
    {
        SceneManager.LoadScene(1);
    }
    public void PlayEndless() 
    {
        SceneManager.LoadScene(2);
    }

    public void PlayCredits () 
    {
        SceneManager.LoadScene(3);
    }

    public void PlayHowToPlay () 
    {
        SceneManager.LoadScene(4);
    }
    public void PlayMenu () 
    {
        SceneManager.LoadScene(0);
    }
}
