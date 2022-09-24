using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBase : MonoBehaviour
{
    //this script contains all the base functionality of the Enemies

    //getters and setters for encapsulation
    protected Text enemyName { get; set; }
    protected Text enemyAttack { get; set; }


    protected AudioSource audioSource;
    
    //shared functions amongst enemies:
    //Attack(), Growl(), Die()

    // Start is called before the first frame update
    protected virtual void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    //these 3 functions are abstraction
    public virtual void Attack()
    {
        //this is where the enemy will say "I'm Attacking!"
        StartCoroutine(TextFlash(enemyAttack));
    }

    public virtual void Growl()
    {
        //this is where the enemy will scream at the player
        StartCoroutine(TextFlash(enemyName));
    }

    public virtual void Die()
    {
        //this is where the enemy will "die"
    }

    /*protected IEnumerator TextFlashAttack(Text enemyAttack)
    {
        enemyAttack.gameObject.SetActive(true);

        float counter = 0;
        float textAppearTime = 0.2f;

        while (counter < textAppearTime)
        {
            counter += Time.deltaTime;
            float time = counter / textAppearTime;
            yield return null;
        }

        yield return new WaitForSeconds(1.0f);
        enemyAttack.gameObject.SetActive(false);
    }*/

    protected IEnumerator TextFlash(Text text)
    {
        text.gameObject.SetActive(true);

        float counter = 0;
        float textAppearTime = 0.2f;

        while (counter < textAppearTime)
        {
            counter += Time.deltaTime;
            float time = counter / textAppearTime;
            yield return null;
        }

        yield return new WaitForSeconds(1.0f);
        text.gameObject.SetActive(false);
    }
}
