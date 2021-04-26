using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpookyGameController : MonoBehaviour
{


    public int playerHealth;

    public int playerStrength;
    public int critDamage;

    //"scenes"
    public GameObject outside;
    public GameObject floor1;
    public GameObject battle;

    // Start is called before the first frame update


    void Start()
    {

        outside.SetActive(true);
        floor1.SetActive(false);
        battle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
 
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
