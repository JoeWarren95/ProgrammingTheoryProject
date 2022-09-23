using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Derive this class from EnemyBase : inheritance
public class Ogre : EnemyBase
{
    public AudioClip ogreGrowl;
    public AudioClip ogreSwipe;
    public AudioClip ogreDeath;

    //maybe make a volume variable bc ogres should be loud (Polymorphism)

    //need to set this enemy's name and attack (Encapsulation)
    public Text ogreAttack;

    protected override void Start()
    {
        base.Start();

        //Encapsulation
        enemyName = "Me Olgut";
        enemyAttack.text = "Club SMASH";
    }

    public override void Attack()
    {
        base.Attack();
        ogreAttack.enabled = true;
        audioSource.PlayOneShot(ogreSwipe);
        ogreAttack.enabled = false;
    }

    //may add in a parameter for this function
    public override void Growl()
    {
        float modifier = Random.Range(0.8f, 1.3f); 
        base.Growl();
        audioSource.pitch = 1.0f * modifier;
        audioSource.PlayOneShot(ogreGrowl);
    }

    public override void Die()
    {
        base.Die();
        audioSource.PlayOneShot(ogreDeath);
    }
}
