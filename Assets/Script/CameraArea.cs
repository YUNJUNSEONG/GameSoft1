using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArea : MonoBehaviour
{
    // �÷��̾�
    public Transform map;

    // ī�޶� �̵� �ӵ�
    public float cameraSpeed;

    // ī�޶� ���� ������ ��ġ�� ũ��
    public Vector2 areaCenter, areaSize;

    // ī�޶��� ����/���� ���� ����
    float heightHalf, widthHalf;

    float distX; // ���� ���� ����
    float distY; // ���� ���� ����

    private void Start()
    {
        // ī�޶��� ���� ���� ���� ��������
        heightHalf = Camera.main.orthographicSize;

        // ī�޶��� ���� ���� ���� ���ϱ�
        widthHalf = heightHalf * Screen.width / Screen.height;

        // ����/���� ���� ���� ���ϱ�
        distX = areaSize.x * 0.5f - widthHalf;
        distY = areaSize.y * 0.5f - heightHalf;
    }

    void LateUpdate() // ������Ʈ�� �����ڸ��� ȣ��
    {
        // �÷��̾��� x,y�� ��������
        Vector3 target = new Vector3(map.position.x, map.position.y, transform.position.z);

        // �÷��̾��� ��ġ�� ������ �̵�
        transform.position = Vector3.Lerp(transform.position, target, cameraSpeed * Time.deltaTime);

        // XY ����
        float clampX = Mathf.Clamp(transform.position.x, areaCenter.x - distX, areaCenter.x + distX);
        float clampY = Mathf.Clamp(transform.position.y, areaCenter.y - distY, areaCenter.y + distY);

        // ī�޶� ���� ����
        transform.position = new Vector3(clampX, clampY, -10);
    }

    private void OnDrawGizmos()
    {
        // ����� ���� �����
        Gizmos.color = Color.yellow;

        // ī�޶� ���� ���� �׸���
        Gizmos.DrawWireCube(areaCenter, areaSize);
    }
}

