using UnityEngine;

public class Platformer : MonoBehaviour
{
    public float moveSpeed = 5f; // �ړ����x
    private Vector3 originalPosition; // �����ʒu
    private bool isPlayerOnPlatform = false; // �v���C���[���v���b�g�t�H�[����ɂ��邩�ǂ���

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (isPlayerOnPlatform)
        {
            // �v���C���[���v���b�g�t�H�[����ɂ���ꍇ�A�ړ����������s
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        else
        {
            // �v���C���[���v���b�g�t�H�[����ɂ��Ȃ��ꍇ�A���̈ʒu�ɖ߂�
            transform.position = originalPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �v���C���[���v���b�g�t�H�[���ɏ�����ꍇ
            isPlayerOnPlatform = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �v���C���[���v���b�g�t�H�[������~�肽�ꍇ
            isPlayerOnPlatform = false;
        }
    }
}
