using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    //�C���X�y�N�^�[����w��
    [SerializeField] Animator anim;
    //[SerializeField] GameObject Player;
    
    private void Start()
    {
        //�����I�u�W�F�N�g�ɂ��Ă���R���|�[�l���g���擾
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        /*if (SceneManager.GetActiveScene().name == "BattleScene")
        {
            //BattleScene�̂Ƃ��CTiger�I�u�W�F�N�g���\��
            gameObject.SetActive(false);
        }
        
        if(SceneManager.GetActiveScene().name == "GameScene")
        {
            gameObject.SetActive(true);
        }
        */





        //�����L�[�������ꂽ��
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetFloat("MoveSpeed", 3.2f);
            //Debug.Log("trueeeeeeee");
        }
        else
        {
            anim.SetFloat("MoveSpeed", 0.0f);
            //anim.SetTrigger("Stop");
            //Debug.Log("falseeeeee");
        }
              
    }

}