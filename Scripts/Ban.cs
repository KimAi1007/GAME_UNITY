using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ban : MonoBehaviour
{
    public float weaponDamage ;
    project myPC;
    public GameObject bulletExplosion;

    [SerializeField] private AudioSource explodeSoundEffect;

    void Awake()
    {
        myPC = GetComponentInParent<project>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shootable")
        {
            explodeSoundEffect.Play();
            myPC.removeForce();
            Instantiate(bulletExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            if(other.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
                hurtEnemy.addDamge(weaponDamage);
            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shootable")
        {
            myPC.removeForce();
            Instantiate(bulletExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
                hurtEnemy.addDamge(weaponDamage);
            }
        }
    }
}
