using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  /*
   // �{�^�����������Ƃ�true�A�������Ƃ�false�ɂȂ�t���O
  private bool LeftKeyDownFlag = false;
  private void Update()
  {
    if (LeftKeyDownFlag)
    {
      // �{�^�����������ςȂ��̏�Ԃ̎��ɂ̂݁uHold�v��\������B
      Debug.Log("Hold");
    }
  }
  
    // �{�^�����������Ƃ��̏���
  public void OnButtonDown()
  {
    Debug.Log("Down");
    LeftKeyDownFlag = true;
  }

  // �{�^���𗣂����Ƃ��̏���
  public void OnButtonUp()
  {
    Debug.Log("Up");
    LeftKeyDownFlag = false;
  }
  */


    
     // �����x
    [SerializeField] private Vector3 _acceleration;

    // �����x
    [SerializeField] private Vector3 _initialVelocity;

    // ���ݑ��x
    private Vector3 _velocity;

    void Start()
    {
        // �����x�ŏ�����
        _velocity = _initialVelocity;
    }
  
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //�����L�[��������Ă���ԁA�������Ɉړ�
            this.transform.Translate(0.0f, 0.0f, 0.1f);

            // �����x�̎��Ԑϕ����瑬�x�����߂�
            _velocity += _acceleration * Time.deltaTime;

            // ���x�̎��Ԑϕ�����ʒu�����߂�
            transform.position += _velocity * Time.deltaTime;
            
                 
        }
        else
        {
            _velocity = Vector3.zero;
        }

    }


}
