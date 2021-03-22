using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool Open = false;
    public bool Locked = false;
    public static Door instance;
    public bool playerClose = false;
    public List<Transform> components;

    public void Update()
    {
        if (Locked == false)
        {
            if (playerClose == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (Open == false)
                    {
                        foreach (Transform child in transform) child.gameObject.SetActive(false);
                        Open = true;
                    }
                    else
                    {
                        foreach (Transform child in transform) child.gameObject.SetActive(true);
                        Open = false;
                    }

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
