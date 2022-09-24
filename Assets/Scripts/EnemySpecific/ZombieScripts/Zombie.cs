using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Derive this class from EnemyBase : INHERITANCE
public class Zombie : EnemyBase
{
    public AudioClip zombieSwipe;
    public AudioClip zombieDeath;
    public AudioClip zombieGrowl;

    //need to set this enemy's name and attack (ENCAPSULATION)
    public Text zombieAttack;
    public Text zombieName;

    //POLYMORPHISM (wherever you see an 'override')
    protected override void Start()
    {
        base.Start();
    }

    public override void Attack()
    {
        zombieAttack.text = "Rotten Swipe!";
        StartCoroutine(TextFlash(zombieAttack));

        base.Attack();
        audioSource.PlayOneShot(zombieSwipe);
    }

    public override void Growl()
    {
        zombieName.text = "*translates to: Trevor*";
        StartCoroutine(TextFlash(zombieName));

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
