using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//սʿ��
public class Warrior : Character
{
    public override void Move(Vector2 direction)
    {
        // ��ʾ������սʿ���ո�������������ٶ��ƶ�������ֻ�Ǹı���λ�ã�ʵ�ʿɽ������ȸ����������
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public override void Attack()
    {
        Debug.Log("Warrior attacks with sword!");
        // ���������Ӹ���ʵ�ʵĹ�������߼������粥�Ŷ����������ײ�˺���
    }
}
