using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour
{
    //���Ԃ�\�����邽�߂�UI������Text�����锠
    public UnityEngine.UI.Text TimeText; 

    public static float countTime; //���ԗp�̃X�N���v�g

    void Start()
    {
        countTime = CountTime2.getCountTime2();
    }

    void FixedUpdate()
    {
        countTime += Time.deltaTime; //���Ԃ𑝂₷
        TimeText.text = countTime.ToString("F2"); //�����_2���Ŏ��Ԃ��e�L�X�g�ɕϊ�

    }

    public static float getCountTime()
    {
        return countTime;
    }

}
