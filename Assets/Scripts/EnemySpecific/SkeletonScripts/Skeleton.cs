using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Derive this class from EnemyBase : inheritance
public class Skeleton : EnemyBase
{
    public AudioClip skeletonSwipe;
    public AudioClip skeletonDeath;
    public AudioClip skeletonGrowl;

    //this will be another instance of polymorphism
    //make a volume variable to make this one sound airy/low (Polymorphism)

    //need to set this enemy's name and attack (Encapsulation)
    public Text skeletonAttack;
    public Text skeletonName;

    protected override void Start()
    {
        base.Start();

        //Encapsulation
        //enemyName = "*Gaspy breath* *translates to: 'Alex'*";
    }

    public override void Attack()
    {
        skeletonAttack.text = "Sword Slash!";
        StartCoroutine(TextFlash(skeletonAttack));

        base.Attack();
        audioSource.PlayOneShot(skeletonSwipe);
    }

    //may add in a parameter for this function
    public override void Growl()
    {
        skeletonName.text = "*translates to: 'I'm Alex'*";
        StartCoroutine(TextFlash(skeletonName));


        float modifier = Random.Range(0.1f, 0.3f);
        base.Growl();
        audioSource.volume = 1.0f * modifier;
        audioSource.PlayOneShot(skeletonGrowl);
    }

    public override void Die()
    {
        base.Die();
        audioSource.PlayOneShot(skeletonDeath);
    }
}
