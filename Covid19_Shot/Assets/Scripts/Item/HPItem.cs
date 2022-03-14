using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem : Item
{

    [SerializeField] int recoverAmount;     //ȸ����


    protected override void Update()
    {
        base.Update();
    }

    protected override void Use()
    {
        player.RecoverHP(recoverAmount);
        base.Use();
    }

}
