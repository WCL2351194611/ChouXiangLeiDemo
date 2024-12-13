using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 抽象角色类，定义角色共有的抽象行为
public abstract class Character : MonoBehaviour
{
    public float speed;

    // 抽象的移动方法，具体怎么移动由子类实现
    public abstract void Move(Vector2 direction);

    // 抽象的攻击方法，具体攻击逻辑由子类实现
    public abstract void Attack();

}
