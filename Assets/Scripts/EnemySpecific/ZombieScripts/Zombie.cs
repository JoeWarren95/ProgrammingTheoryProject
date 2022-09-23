using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Derive this class from EnemyBase : inheritance
public class Zombie : EnemyBase
{
    public AudioClip zombieSwipe;
    public AudioClip zombieDeath;
    public AudioClip zombieGrowl;

    //need to set this enemy's name and attack (Encapsulation)


    protected override void Start()
    {
        base.Start();

        //Encapsulation
        enemyName = "Blaaaaarrrrgggh *translates to: Trevor*";
        //enemyAttack = "Rotten Swipe";
        enemyAttack.text = "Rotten Swipe!";
    }

    public override void Attack()
    {
        base.Attack();
        audioSource.PlayOneShot(zombieSwipe);
    }

    public override void Growl()
    {
        float modifier = Random.Range(0.3f, 0.5f);
        float pitchMod = Random.Range(1.0f, 1.3f);
        base.Growl();
        audioSource.volume = 1 * modifier;
        audioSource.pitch = 1.0f * pitchMod;
        audioSource.PlayOneShot(zombieGrowl);
    }

    public override void Die()
    {
        base.Die();
        audioSource.PlayOneShot(zombieDeath);
    }
}
