using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyDeleteScript : MonoBehaviour
{
    [SerializeField]
    static public bool death = false;


    void Awake()
    {
    
        DontDestroyOnLoad(gameObject);
        

    }

    void OnCollisionEnter(Collision collision)
    {

    }



    public void setDeath(bool arg)
    {
        death = arg;
    }

    //OnTriggerEnter�֐�
    //�ڐG�����I�u�W�F�N�g������other�Ƃ��ēn�����
    /*void OnOnCollisionEnter(Collision collision)
    {
        //�ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̂Ƃ�
        if (collision.gameObject.name == "tiger_idle")
        {
            //�I�u�W�F�N�g������
            gameObject.SetActive(false);
        }
    }*/






}
