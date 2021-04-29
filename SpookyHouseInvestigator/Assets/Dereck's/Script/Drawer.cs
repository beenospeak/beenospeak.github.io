using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Drawer : MonoBehaviour
{
    public static Drawer instance;
    public bool Locked = false;
    public bool Opened = false;
    public bool playerClose = false;

    // Update is called once per frame
    void Update()
    {
        if (Locked == false && playerClose == true)
        {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (Opened == false)
                    {
                        Opened = true;
                        GiveItem.instance.GotKey();
                        Door.instance.GotKey();
                        //Animation
                    }
                }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerInside"))
        {
            playerClose = true;
        }
        if (other.gameObject.CompareTag("PlayerOutside"))
        {
            playerClose = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerInside"))
        {
            playerClose = false;
        }
        if (other.gameObject.CompareTag("PlayerOutside"))
        {
            playerClose = false;
        }
    }
}
