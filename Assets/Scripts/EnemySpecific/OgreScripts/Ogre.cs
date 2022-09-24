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
    public Text ogreName;

    protected override void Start()
    {
        base.Start();
    }

    public override void Attack()
    {
        ogreAttack.text = "club SMASH!!";

        base.Attack();
        StartCoroutine(TextFlash(ogreAttack));

        audioSource.PlayOneShot(ogreSwipe);
    }

    //may add in a parameter for this function
    public override void Growl()
    {
        ogreName.text = "translation: ME OLGUK";
        float modifier = Random.Range(0.8f, 1.3f); 
        base.Growl();
        StartCoroutine(TextFlash(ogreName));

        audioSource.pitch = 1.0f * modifier;
        audioSource.PlayOneShot(ogreGrowl);
    }

    public override void Die()
    {
        base.Die();
        audioSource.PlayOneShot(ogreDeath);
    }
}
