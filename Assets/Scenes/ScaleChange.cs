using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    public float scaleSpeed = 0.5f; // �X�P�[�����ω����鑬�x
    public float maxScale = 2f;     // �ő�X�P�[��
    public float minScale = 0.5f;   // �ŏ��X�P�[��

    private bool scalingUp = true;  // �X�P�[�����g�咆���ǂ����̃t���O

    void Update()
    {
        // �X�P�[����ω�������
        if (scalingUp)
        {
            transform.localScale += new Vector3(scaleSpeed * Time.deltaTime, 0f, 0f);

            // �ő�X�P�[���𒴂�����X�P�[���_�E���ɐ؂�ւ�
            if (transform.localScale.x >= maxScale)
            {
                scalingUp = false;
            }
        }
        else
        {
            transform.localScale -= new Vector3(scaleSpeed * Time.deltaTime, 0f, 0f);

            // �ŏ��X�P�[�������������X�P�[���A�b�v�ɐ؂�ւ�
            if (transform.localScale.x <= minScale)
            {
                scalingUp = true;
            }
        }
    }
}
