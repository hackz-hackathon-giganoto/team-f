using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    //�C���X�y�N�^�[����w��
    [SerializeField] Animator anim;

    
    private void Start()
    {
        //�����I�u�W�F�N�g�ɂ��Ă���R���|�[�l���g���擾
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        //�����L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetFloat("MoveSpeed", 3.2f);
            Debug.Log("trueeeeeeee");
        }
        else
        {
            //anim.SetFloat("MoveSpeed", 0.0f);
            //anim.SetTrigger("Stop");
            Debug.Log("falseeeeee");
        }
              
    }

}