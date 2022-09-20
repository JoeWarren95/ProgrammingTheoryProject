using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Derive this class from EnemyBase
public class Skeleton : EnemyBase
{
    public AudioClip skeletonSwipe;
    public AudioClip skeletonDeath;
    public AudioClip skeletonGrowl;

    public override void Attack()
    {
        base.Attack();
        audioSource.PlayOneShot(skeletonSwipe);
    }

    public override void Growl()
    {
        base.Growl();
        audioSource.PlayOneShot(skeletonGrowl);
    }

    public override void Die()
    {
        base.Die();
        audioSource.PlayOneShot(skeletonDeath);
    }
}
