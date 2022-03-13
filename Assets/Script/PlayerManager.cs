using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //�C���X�y�N�^�[����w��
    [SerializeField] Animator animator;

    void Start()
    {
        //animator�R���|�[�l���g�̎擾
        animator = GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        //�����L�[�������ꂽ�Ƃ�
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //�A�j���[�^�[��Bool"Running"�̔���
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);
        }

        //�E���L�[�������ꂽ�Ƃ�
        /*if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //�A�j���[�^�[��Bool"Walking"�̔���
            animator.SetBool("Walking",true);
        }
        else
        {
            animator.SetBool("Running", false);
        }*/
    }
}
