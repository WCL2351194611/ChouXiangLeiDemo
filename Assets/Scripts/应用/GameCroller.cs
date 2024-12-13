using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCroller : MonoBehaviour
{
    public GameObject warriorPrefab;
    public GameObject magePrefab;

    private void Start()
    {
        // ����սʿʵ��
        var warriorInstance = Instantiate(warriorPrefab,this.transform).GetComponent<Character>();
        warriorInstance.speed = 30f;
        warriorInstance.Move(Vector2.right);
        warriorInstance.Attack();

        // ������ʦʵ��
        var mageInstance = Instantiate(magePrefab).GetComponent<Character>();
        mageInstance.speed = 20f;
        mageInstance.Move(Vector2.left);
        mageInstance.Attack();
    }
}
