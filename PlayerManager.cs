using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    public float health = 100;
    public Text healthNumber;

    public GameManager gameManager;

    public void Hit(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            gameManager.EndGame();
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        healthNumber.text = "Health : " + health.ToString();
    }
}
