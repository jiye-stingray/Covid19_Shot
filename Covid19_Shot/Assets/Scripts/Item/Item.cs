using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] protected int speed;
    protected Rigidbody2D rigid;
    protected Player player => SystemManager.Instance.Player;

    protected virtual void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    protected virtual void Start()
    {
        rigid.AddForce(Vector2.down.normalized * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Use()
    {
        Destroy(gameObject);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Use();
        }
    }
}
