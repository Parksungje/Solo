using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalEnemyCount; //���־��ϴ� �� ��
    public int stage; //�������� ��ȣ

    void Awake()
    {
        stage = 0;
    }
}
