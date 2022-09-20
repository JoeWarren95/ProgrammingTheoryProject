using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Derive this class from EnemyBase
public class Ogre : EnemyBase
{
    public AudioClip ogreGrowl;
    public AudioClip ogreSwipe;
    public AudioClip ogreDeath;

    public override void Attack()
    {
        base.Attack();
        audioSource.PlayOneShot(ogreSwipe);
    }

    public override void Growl()
    {
        base.Growl();
        audioSource.PlayOneShot(ogreGrowl);
        Debug.Log("I'm growling");
    }

    public override void Die()
    {
        base.Die();
        audioSource.PlayOneShot(ogreDeath);
    }
}
