using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    //IN CLASS COLLEGE NOW MW

    //GLOBAL VARIABLES
    public int damage;
    public PlayerController playerControllerScript;

    //patrol point stuff
    public Transform[] patrolPoints;
    public float moveSpeed = 3;
    public int patrolDestination; //set to default of 0

    // Start is called before the first frame update
    void Start()
    {
        damage = 2; 
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("hit player");
            playerControllerScript.TakeDamage(damage); 
        }
    }

    private void EnemyMovement()
    {
        //if the patrolDestination is 0...
        if (patrolDestination == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, patrolPoints[0].position) < 0.4f)
            {
                patrolDestination = 1; 
            }
        }

        if (patrolDestination == 1)
        {
            Debug.Log("go to the right"); 
        }
    }
}
