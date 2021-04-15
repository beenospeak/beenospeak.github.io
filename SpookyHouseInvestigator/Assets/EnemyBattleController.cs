using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBattleController : MonoBehaviour
{
    public GameObject player;

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
        StartCoroutine(Test());
    }


    IEnumerator Test()
    {
        yield return new WaitForSeconds(3);
        player.SetActive(true);
    }

}
