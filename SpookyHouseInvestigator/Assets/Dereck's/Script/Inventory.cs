using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public GameObject InvSlot1;
    public GameObject InvSlot2;
    public GameObject InvSlot3;
    public GameObject InvSlot4;
    public GameObject InvSlot5;
    public GameObject InvSlot6;
    public int Slot = 1;

    void Update()
    {
        if (Slot == 1)
        {
            InvSlot1.SetActive(true);
            InvSlot2.SetActive(false);
            InvSlot3.SetActive(false);
            InvSlot4.SetActive(false);
            InvSlot5.SetActive(false);
            InvSlot6.SetActive(false);
        }
        else if (Slot == 2)
        {
            InvSlot1.SetActive(false);
            InvSlot2.SetActive(true);
            InvSlot3.SetActive(false);
            InvSlot4.SetActive(false);
            InvSlot5.SetActive(false);
            InvSlot6.SetActive(false);
        }
        else if (Slot == 3)
        {
            InvSlot1.SetActive(false);
            InvSlot2.SetActive(false);
            InvSlot3.SetActive(true);
            InvSlot4.SetActive(false);
            InvSlot5.SetActive(false);
            InvSlot6.SetActive(false);
        }
        else if (Slot == 4)
        {
            InvSlot1.SetActive(false);
            InvSlot2.SetActive(false);
            InvSlot3.SetActive(false);
            InvSlot4.SetActive(true);
            InvSlot5.SetActive(false);
            InvSlot6.SetActive(false);
        }
        else if (Slot == 5)
        {
            InvSlot1.SetActive(false);
            InvSlot2.SetActive(false);
            InvSlot3.SetActive(false);
            InvSlot4.SetActive(false);
            InvSlot5.SetActive(true);
            InvSlot6.SetActive(false);
        }
        else if (Slot == 6)
        {
            InvSlot1.SetActive(false);
            InvSlot2.SetActive(false);
            InvSlot3.SetActive(false);
            InvSlot4.SetActive(false);
            InvSlot5.SetActive(false);
            InvSlot6.SetActive(true);
        }
        else if (Slot >= 7)
        {
            Slot = 1;
        }
        else if (Slot <= 0)
            Slot = 6;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Slot += 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Slot -= 1;
        }
    }
}
