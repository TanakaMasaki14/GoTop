using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public Transform startPoint;    // �ړ��̎n�_
    public Transform endPoint;      // �ړ��̏I�_
    public float moveSpeed = 2f;    // �ړ����x

    private Vector3 targetPosition; // ���݂̈ړ���̈ʒu

    private void Start()
    {
        targetPosition = endPoint.position;
    }

    private void Update()
    {
        // ���݂̈ʒu����ڕW�ʒu�Ɍ������Ĉړ�
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // �ڕW�ʒu�ɓ��B������A�ڕW�ʒu��؂�ւ���
        if (transform.position == targetPosition)
        {
            if (targetPosition == endPoint.position)
                targetPosition = startPoint.position;
            else
                targetPosition = endPoint.position;
        }
    }
}
