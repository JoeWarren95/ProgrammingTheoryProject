using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    //this script contains all the base functionality of the Enemies

    //getters and setters for encapsulation
    protected string enemyName { get; set; }
    protected string enemyAttack { get; set; }

    protected AudioSource audioSource;
    //protected AudioClip enemyGrowl;
    
    //shared functions amongst enemies:
    //Attack(), Growl(), Die()

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    //these 3 functions are abstraction
    public virtual void Attack()
    {
        //this is where the enemy will say "I'm Attacking!"
    }

    public virtual void Growl()
    {
        //this is where the enemy will scream at the player
    }

    public virtual void Die()
    {
        //this is where the enemy will "die"
    }
}
