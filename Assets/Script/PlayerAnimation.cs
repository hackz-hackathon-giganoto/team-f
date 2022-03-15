using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Animator anim; //�C���X�y�N�^�[������o����悤�ɂ���
    private Rigidbody rb;
    public float upForce = 200f;
    private bool isGround;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey("up")) //��L�[�������ꂽ�Ƃ��O�֕���
        {
            transform.position += transform.forward * 0.01f;
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        /*if (Input.GetKey("left shift") && Input.GetKey("up")) //Shift�L�[����L�[��������Ă����
        {
            transform.position += transform.forward * 0.03f; //�X�s�[�h�A�b�v
            anim.SetBool("Running", true); //����A�j���[�V����������
        }*/

        if (Input.GetKeyUp("left shift")) //Shift�L�[�𗣂����Ƃ�
        {
            anim.SetBool("Running", false); //����A�j���[�V��������߂�

        }

        

        if (isGround == true)
        {
            if (Input.GetKeyDown("space"))
            {
                anim.SetBool("Jumping", true);
                isGround = false;
                rb.AddForce(new Vector3(0, upForce, 0));
            }
        }

    }

}
