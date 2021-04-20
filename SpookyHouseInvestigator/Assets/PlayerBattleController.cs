using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattleController : MonoBehaviour
{

    public GameObject enemy;
    public GameObject gamecontroller;
    public int crit;
    public int critChance;

    // Start is called before the first frame update
    void Start()
    {
        enemy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        enemy.SetActive(false);
    }

    public void Attack()
    {
        crit = Random.Range(1, (critChance) + 1);
        if (crit == 1)
        {
            gamecontroller.gameObject.GetComponent<SpookyGameController>().enemyHealth -= gamecontroller.gameObject.GetComponent<SpookyGameController>().playerStrength + gamecontroller.gameObject.GetComponent<SpookyGameController>().critDamage;
        }
        else
        {
            gamecontroller.gameObject.GetComponent<SpookyGameController>().enemyHealth -= gamecontroller.gameObject.GetComponent<SpookyGameController>().playerStrength;
        }
        
        enemy.SetActive(true);
    }
}