using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//战士类
public class Warrior : Character
{
    public override void Move(Vector2 direction)
    {
        // 简单示例，让战士按照给定方向和自身速度移动（这里只是改变了位置，实际可结合物理等更复杂情况）
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public override void Attack()
    {
        Debug.Log("Warrior attacks with sword!");
        // 这里可以添加更多实际的攻击相关逻辑，比如播放动画、检测碰撞伤害等
    }
}
