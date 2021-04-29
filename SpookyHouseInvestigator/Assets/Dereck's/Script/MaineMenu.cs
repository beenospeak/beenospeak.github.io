using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MaineMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("OutSide");
    }
}
