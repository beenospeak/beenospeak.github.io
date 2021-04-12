using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public bool Open = false;
    public bool Locked = false;
    public static Door instance;
    public bool playerClose = false;
    public GameObject OpenDoor;
    public GameObject ClosedDoor;

    private void Start()
    {
        OpenDoor.SetActive(false);
        ClosedDoor.SetActive(true);
    }

    public void Update()
    {
        if (Locked == false && playerClose == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Open == false)
                {
                    OpenDoor.SetActive(true);
                    ClosedDoor.SetActive(false);
                    Open = true;
                }
                else
                {
                    OpenDoor.SetActive(false);
                    ClosedDoor.SetActive(true);
                    Open = false;
                }

            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerClose = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerClose = false;
        }
    }

    public void GotKey()
    {
        Locked = false;
    }



}
