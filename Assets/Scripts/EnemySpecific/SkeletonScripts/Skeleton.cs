using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Derive this class from EnemyBase : INHERITANCE
public class Skeleton : EnemyBase
{
    public AudioClip skeletonSwipe;
    public AudioClip skeletonDeath;
    public AudioClip skeletonGrowl;

    //need to set this enemy's name and attack (ENCAPSULATION)
    public Text skeletonAttack;
    public Text skeletonName;

    //POLYMORPHISM (wherever you see an 'override')
    protected override void Start()
    {
        base.Start();
    }

    public override void Attack()
    {
        skeletonAttack.text = "Sword Slash!";
        StartCoroutine(TextFlash(skeletonAttack));

        base.Attack();
        audioSource.PlayOneShot(skeletonSwipe);
    }

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
