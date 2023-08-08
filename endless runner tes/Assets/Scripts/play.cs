using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("ingame");
    }

    public void Quit()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
