using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGameClearText : MonoBehaviour
{

    //Inspector�ŃL�����N�^�[�ƃS�[���I�u�W�F�N�g�̎w�肪�ł���悤�ɂ���
    [SerializeField] GameObject chara;
    [SerializeField] GameObject gameclear;

    private void OnTriggerEnter(Collider other)
    {
        //�����S�[���I�u�W�F�N�g�̃R���C�_�[�ɐڐG�����Ƃ��̏���
        if(other.name == chara.name)
        {
            //�Q�[���N���A�e�L�X�g��\�������ăL�����N�^�[���\���ɂ���
            gameclear.GetComponent<Text>();
            gameclear.SetActive(true);
            chara.SetActive(false);
        }
    }
}
