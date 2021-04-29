using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fight : MonoBehaviour
{
    bool yourTurn;
    public int crit = 1;
    public GameObject choices;
    public GameObject attack;
    public GameObject items;
    public GameObject talk;

    void start()
    {
        choices.SetActive(true);
        talk.SetActive(false);
        items.SetActive(false);
        attack.SetActive(false);
    }

    public void attackClicked()
    {
        choices.SetActive(false);
        attack.SetActive(true);
    }

    public void itemsClicked()
    {
        choices.SetActive(false);
        items.SetActive(true);
    }

    public void talkClicked()
    {
        choices.SetActive(false);
        talk.SetActive(true);
    }

    public void backClicked()
    {
        choices.SetActive(true);
        talk.SetActive(false);
        items.SetActive(false);
        attack.SetActive(false);
    }




}

