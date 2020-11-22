using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject sound;
    public void PlayAdventure () 
    {
        Instantiate(sound, this.gameObject.transform.position, Quaternion.identity);
        Invoke("Scene1", 0.25f);
    }
    public void PlayEndless() 
    {
        Instantiate(sound, this.gameObject.transform.position, Quaternion.identity);
        Invoke("Scene2", 0.25f);
    }

    public void PlayCredits () 
    {
        Instantiate(sound, this.gameObject.transform.position, Quaternion.identity);
        Invoke("Scene3", 0.25f);
    }

    public void PlayHowToPlay () 
    {
        Instantiate(sound, this.gameObject.transform.position, Quaternion.identity);
        Invoke("Scene4", 0.25f);
    }
    public void PlayMenu () 
    {
        Instantiate(sound, this.gameObject.transform.position, Quaternion.identity);
        Invoke("Scene0", 0.25f);
    }

    public void Scene1()
    {
        SceneManager.LoadScene(1);
    }

    public void Scene2()
    {
        SceneManager.LoadScene(2);
    }

    public void Scene3()
    {
        SceneManager.LoadScene(3);
    }
    
    public void Scene4()
    {
        SceneManager.LoadScene(4);
    }

    public void Scene0()
    {
        SceneManager.LoadScene(0);
    }
}
