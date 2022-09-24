using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Derive this class from EnemyBase : inheritance
public class Zombie : EnemyBase
{
    public AudioClip zombieSwipe;
    public AudioClip zombieDeath;
    public AudioClip zombieGrowl;

    //need to set this enemy's name and attack (Encapsulation)
    public Text zombieAttack;
    public Text zombieName;

    protected override void Start()
    {
        base.Start();

        //Encapsulation
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

    /*protected IEnumerator TextFlash(Text zombieAttack)
    {
        ogreAttack.gameObject.SetActive(true);

        float counter = 0;
        float textAppearTime = 0.2f;

        while (counter < textAppearTime)
        {
            counter += Time.deltaTime;
            float time = counter / textAppearTime;
            yield return null;
        }

        yield return new WaitForSeconds(1.0f);
        ogreAttack.gameObject.SetActive(false);
    }*/
}
