using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {

    }

  
    void FixedUpdate()
    {
        /*if(Input.GetKey(KeyCode.LeftArrow))
        {
            //�����L�[��������Ă���ԁA�������Ɉړ�
            this.transform.Translate(0.0f, 0.0f, 0.1f);
        }*/

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //�����L�[��������Ă���ԁA�������Ɉړ�
            this.transform.Translate(0.0f, 0.0f, 0.1f);
        }
    }
}
