using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime2 : MonoBehaviour
{
    public static float CountTime_2;
    //���Ԃ�\�����邽�߂�UI������Text�����锠
    public UnityEngine.UI.Text TimeText2;

    void Start()
    {
        //CountTime�X�N���v�g�̂���CountTime���\�b�h�̒l���Q��
        CountTime_2 = CountTime.getCountTime();

    }

    void FixedUpdate()
    {
        CountTime_2 += Time.deltaTime; //���Ԃ𑝂₷
        TimeText2.text = CountTime_2.ToString("F2"); //�����_2���Ŏ��Ԃ��e�L�X�g�ɕϊ�
    }

    public static float getCountTime2()
    {
        return CountTime_2;
    }

}
