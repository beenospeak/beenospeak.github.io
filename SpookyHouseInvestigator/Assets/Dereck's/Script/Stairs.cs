using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stairs : MonoBehaviour
{
    public bool isNear;

    void Update()
    {
       if(isNear && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("UpStairs");
        } 
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerInside"))
        {
            isNear = true;
        }
        if (other.gameObject.CompareTag("PlayerOutside"))
        {
            isNear = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerInside"))
        {
            isNear = false;
        }
        if (other.gameObject.CompareTag("PlayerOutside"))
        {
            isNear = false;
        }
    }
}
