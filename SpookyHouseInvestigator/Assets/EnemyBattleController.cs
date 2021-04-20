using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBattleController : MonoBehaviour
{
    public GameObject player;
    public GameObject attackbutton;
    public GameObject gamecontroller;
    public float enemyStrength;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        player.SetActive(false);
        attackbutton.SetActive(false);
        StartCoroutine(Test());
    }


    IEnumerator Test()
    {
        yield return new WaitForSeconds(1);
        player.SetActive(true);
        gamecontroller.gameObject.GetComponent<SpookyGameController>().playerHealth -= enemyStrength;
        attackbutton.SetActive(true);
    }

}
