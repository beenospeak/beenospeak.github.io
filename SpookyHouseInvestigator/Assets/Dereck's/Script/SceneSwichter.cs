using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwichter : MonoBehaviour
{
    public bool Locked = false;
    public bool playerInsideClose;
    public bool playerOutsideClose;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
        this.gameObject.SetActive(false);
    }

    void Update()
    {
        if (playerInsideClose == true && Locked == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Outside");
            }
        }

        if (playerOutsideClose == true && Locked == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Inside");
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerInside"))
            playerInsideClose = true;
        if (other.gameObject.CompareTag("PlayerOutside"))
            playerOutsideClose = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerInside"))
            playerInsideClose = false;

        if (other.gameObject.CompareTag("PlayerOutside"))
            playerOutsideClose = false;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Menu")
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            Destroy(this.gameObject);
        }
        else
        {
            this.gameObject.SetActive(scene.name == "Inside");
        }
    }
}
