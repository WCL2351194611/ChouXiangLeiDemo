using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �����ɫ�࣬�����ɫ���еĳ�����Ϊ
public abstract class Character : MonoBehaviour
{
    public float speed;

    // ������ƶ�������������ô�ƶ�������ʵ��
    public abstract void Move(Vector2 direction);

    // ����Ĺ������������幥���߼�������ʵ��
    public abstract void Attack();

}
