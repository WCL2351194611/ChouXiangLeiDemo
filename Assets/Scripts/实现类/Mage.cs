using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ħ��ʦ
public class Mage : Character
{
    public override void Move(Vector2 direction)
    {
        // ��ʦ�����ƶ���ʽ��ͬ�������и�˲�Ƶ�Ч��������򵥰������ƶ�ʾ����
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public override void Attack()
    {
        Debug.Log("Mage casts a spell!");
        // ʵ�ʿ����������ħ����Ч������˺���Χ�Ⱦ����߼�
    }
}
