using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Derive this class from EnemyBase
public class Zombie : EnemyBase
{
    public AudioClip zombieSwipe;
    public AudioClip zombieDeath;
    public AudioClip zombieGrowl;

    public override void Attack()
    {
        base.Attack();
        enemyAttack = "blaaaaaarrrrrggghhhh";
        audioSource.PlayOneShot(zombieSwipe);
    }

    public override void Growl()
    {
        base.Growl();
        audioSource.PlayOneShot(zombieGrowl);
    }

    public override void Die()
    {
        base.Die();
        audioSource.PlayOneShot(zombieDeath);
    }
}
