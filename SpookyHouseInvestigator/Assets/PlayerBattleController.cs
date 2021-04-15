using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattleController : MonoBehaviour
{

    public GameObject enemy;

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
        enemy.SetActive(true);
    }
}
