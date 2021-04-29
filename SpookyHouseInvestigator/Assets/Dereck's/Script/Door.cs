using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public static Door instance = null;
    public bool playerClose;
    public bool Open;
    public bool Locked;
    public bool hasKey;
    public GameObject OpenDoor;
    public GameObject ClosedDoor;

    void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
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
        if (hasKey == true && playerClose == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Locked = false;
                GiveItem.instance.Usedkey();
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerInside"))
            playerClose = true;
        if (other.gameObject.CompareTag("PlayerOutside"))
            playerClose = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerInside"))
            playerClose = false;

        if (other.gameObject.CompareTag("PlayerOutside"))
            playerClose = false;
    }

    public void GotKey()
    {
        hasKey = true;
    }



}
