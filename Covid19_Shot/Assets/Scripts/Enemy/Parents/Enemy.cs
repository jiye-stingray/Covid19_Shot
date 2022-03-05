using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP;
    public int speed;
    Rigidbody2D rigid;


    protected virtual void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }


    protected virtual void Start()
    {
        rigid.AddForce(Vector2.down * speed);
    }

    protected virtual void Update()
    {
        if (HP <= 0)
        {
            Dead();
        }
    }

    public virtual void Dead()
    {
        Destroy(gameObject);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            //�÷��̾��� ���� ������ +


            Dead();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            HP -=
                collision.gameObject.GetComponent<Bullet>().damage;
        }
    }
        
        
    
}
