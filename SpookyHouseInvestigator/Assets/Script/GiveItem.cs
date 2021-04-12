using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GiveItem : MonoBehaviour
{
    public static GiveItem insantce = null;
    public GameObject HouseKey1;
    public GameObject HouseKey2;
    public GameObject HouseKey3;
    public GameObject HouseKey4;
    public GameObject HouseKey5;
    public GameObject HouseKey6;
    public int Slot = 1;
    public bool isFull;

    void Start()
    {
        if (insantce == null)
            insantce = this;
        else
            Destroy(gameObject);

    }

    public void GotKey()
    {
        if (isFull == false)
        {
            switch (Slot)
            {
                case 1:
                    HouseKey1.SetActive(true);
                    Slot += 1;
                    break;
                case 2:
                    HouseKey2.SetActive(true);
                    Slot += 1;
                    break;
                case 3:
                    HouseKey3.SetActive(true);
                    Slot += 1;
                    break;
                case 4:
                    HouseKey4.SetActive(true);
                    Slot += 1;
                    break;
                case 5:
                    HouseKey5.SetActive(true);
                    Slot += 1;
                    break;
                case 6:
                    HouseKey6.SetActive(true);
                    Slot += 1;
                    break;
                default:
                    isFull = true;
                    break;
            }
        }
    }

   
}
