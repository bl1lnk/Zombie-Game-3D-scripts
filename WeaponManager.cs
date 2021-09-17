using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject playerCam;
    public float range = 100f;
    public float damage = 25f;
    public Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerAnimator.GetBool("isShotting"))
        {
            playerAnimator.SetBool("isShotting", false);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("Shott !");
            Shoot();
        }
    }

    void Shoot()
    {
        playerAnimator.SetBool("isShotting", true);
        RaycastHit hit;

        if(Physics.Raycast(playerCam.transform.position, transform.forward, out hit, range))
        {
            EnemyManager enemyManager = hit.transform.GetComponent<EnemyManager>();

            if(enemyManager != null)
            {
               
                enemyManager.Hit(damage);
            }
            
        }
    }
}
