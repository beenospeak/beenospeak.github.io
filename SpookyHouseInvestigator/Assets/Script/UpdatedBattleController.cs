using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatedBattleController : MonoBehaviour
{

    public GameObject Controller;

    public GameObject AttackButton;

    public Text PlayerHealthBar;
    public Text EnemyHealthBar;

    public int enemyHealth;
    public int enemyStrength;

    public int crit;
    public int critChance;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealthBar.text = Controller.gameObject.GetComponent<SpookyGameController>().playerHealth.ToString();
        EnemyHealthBar.text = enemyHealth.ToString();

        if (enemyHealth <= 0)
        {
            PlayerWins();
        }

        if (Controller.gameObject.GetComponent<SpookyGameController>().playerHealth <= 0)
        {
            EnemyWins();
        }

    }


    //This is the player's turn, it's activated when the attack button is clicked
    public void PlayerAttack ()
    {
        crit = Random.Range(1, (critChance) + 1);
        if (crit == 1)
        {
            enemyHealth -= Controller.gameObject.GetComponent<SpookyGameController>().playerStrength + Controller.gameObject.GetComponent<SpookyGameController>().critDamage;
        }
        else
        {
            enemyHealth -= Controller.gameObject.GetComponent<SpookyGameController>().playerStrength;
        }

        EnemyAttack();
    }

    //This is the enemy's turn, it's activated right after the player's turn
    public void EnemyAttack ()
    {
        AttackButton.SetActive(false);
        StartCoroutine(EnemyHit());
    }

    IEnumerator EnemyHit ()
    {
        yield return new WaitForSeconds(1);
        Controller.gameObject.GetComponent<SpookyGameController>().playerHealth -= enemyStrength;
        AttackButton.SetActive(true);
    }

    //Haven't added anything for these yet

    public void PlayerWins()
    {

    }
    public void EnemyWins()
    {

    }

}
