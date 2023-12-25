using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // �ǂ�������Ώہi�v���C���[�L�����N�^�[�j��Transform�R���|�[�l���g
    public Vector3 offset;    // �J�����ƃv���C���[�̋����I�t�Z�b�g

    private void LateUpdate()
    {
        if (target != null)
        {
            // �v���C���[�̈ʒu�ɃI�t�Z�b�g�������ăJ�����̃^�[�Q�b�g�ʒu���v�Z
            Vector3 targetPosition = target.position + offset;

            // �J�����̈ʒu�����X�Ƀ^�[�Q�b�g�ʒu�Ɉړ�������i�X���[�Y�Ȉړ��������j
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);
        }
    }
}