using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public GameObject Gem;
    public static bool IsAttacked = false;
    public static Animator MyAnimator;
    private bool spawnGem = false;
    private bool levelUp = false;
    private Animator myAnimator;
    public static int life;
    private float timer;
    private int newLife;
    public static bool CanDamage = false;
    private void Awake()
    {


        timer = 2f;
        IsAttacked = false;



        CanDamage = false;

    }
    void Start()
    {
        life = Level.LevelCount + 9;
        MyAnimator = gameObject.GetComponent<Animator>();
        myAnimator = gameObject.GetComponent<Animator>();

        levelUp = true;
        spawnGem = true;
    }


    void Update()
    {
        if (this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("AttackedAnimation") || this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("IdleAnimation"))
        {
            CanDamage = true;
        }
        else
        {
            CanDamage = false;
        }
        newLife = Random.Range(1, 4);
        if (!this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("AttackedAnimation"))
        {
            IsAttacked = true;

        }
        else
        {
            IsAttacked = false;
        }
        if (this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("ShowAnimation"))
        {
            GiveDamage.CanSpawn = false;
        }
        else
        {
            GiveDamage.CanSpawn = true;
        }
        if (life <= 0)
        {
            MyAnimator.SetInteger("life", 0);

            timer -= Time.deltaTime;

            if (spawnGem)
            {
                Instantiate(Gem, new Vector2(0, -0.5f), Quaternion.identity);
                spawnGem = false;
            }
            else if (levelUp && this.myAnimator.GetCurrentAnimatorStateInfo(0).IsName("EnemyIdle"))
            {
                Level.LevelCount += 1;
                levelUp = false;
            }
        }

        if (life <= 0 && timer <= 0 && Level.LevelCount != 11)
        {
            Instantiate(gameObject, new Vector2(-3.289465f, 2.67f), Quaternion.identity);
            Destroy(gameObject);

        }


    }
}
