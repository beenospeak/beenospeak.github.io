using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpookyGameController : MonoBehaviour
{

    public float actionA;
    public float test;

    public float playerHealth;
    public float enemyHealth;

    public float playerStrength;
    public float critDamage;

    public Text playerhealthbar;
    public Text enemyhealthbar;

    //"scenes"
    public GameObject outside;
    public GameObject floor1;
    public GameObject battle;

    // Start is called before the first frame update


    void Start()
    {
        playerHealth = 100;
        enemyHealth = 100;

        outside.SetActive(true);
        floor1.SetActive(false);
        battle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        playerhealthbar.text = playerHealth.ToString();
        enemyhealthbar.text = enemyHealth.ToString();
    }

    //Scenes

    public void Outside()
    {
        outside.SetActive(true);
        floor1.SetActive(false);
        battle.SetActive(false);
    }

    public void Floor1()
    {
        outside.SetActive(false);
        floor1.SetActive(true);
        battle.SetActive(false);
    }

    public void Battle()
    {
        outside.SetActive(false);
        floor1.SetActive(false);
        battle.SetActive(true);
    }

}
