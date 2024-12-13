using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//魔法师
public class Mage : Character
{
    public override void Move(Vector2 direction)
    {
        // 法师可能移动方式不同，比如有个瞬移等效果（这里简单按常规移动示例）
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public override void Attack()
    {
        Debug.Log("Mage casts a spell!");
        // 实际可以添加生成魔法特效、检测伤害范围等具体逻辑
    }
}
