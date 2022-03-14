using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBloodCell : NPC
{


    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
    }



    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    protected override void Dead()
    {
        //�÷��̾� ��������� ����

        base.Dead();

    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.gameObject.CompareTag("Bullet"))
        {
            Bullet bullet = collision.gameObject.GetComponent<Bullet>();

            if (bullet.myBullet == Bullet.BulletType.Enemy)//�� �Ѿ��� �¾��� ��
            {
                Dead();
            }
        }
    }
}