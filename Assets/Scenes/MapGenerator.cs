using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject roomPrefab; // ���� ��Ÿ���� ������
    public Material roomMaterial; // ���� ��Ƽ����

    void Start()
    {
        GenerateMap();
    }

    void GenerateMap()
    {
        int gridSizeX = 15;
        int gridSizeY = 7;

        for (int i = 0; i < 6; i++)
        {
            GenerateFloor(gridSizeX, gridSizeY, i);
        }
    }

    void GenerateFloor(int sizeX, int sizeY, int floorNumber)
    {
        for (int x = 0; x < sizeX; x++)
        {
            // �� ����
            GameObject newRoom = Instantiate(roomPrefab, new Vector3(x, floorNumber, 0), Quaternion.identity);

            // �濡 Renderer ������Ʈ�� ������ �߰�
            Renderer roomRenderer = newRoom.GetComponent<Renderer>();
            if (roomRenderer == null)
            {
                roomRenderer = newRoom.AddComponent<Renderer>();
            }

            // ���� ��Ƽ���� ����
            if (roomMaterial != null)
            {
                roomRenderer.material = roomMaterial;
            }

            // ������ ���� ���� �� ����
            Color randomColor = Random.ColorHSV();
            roomRenderer.material.color = randomColor;
        }
    }

    // OnDrawGizmos �޼��带 �߰��Ͽ� Gizmo�� ����
    void OnDrawGizmos()
    {
        Gizmos.color = Color.black; // ���ϴ� �������� ����

        // Gizmo�� ���� �ð������� Ȯ���� ���� �߰�
        Gizmos.DrawLine(transform.position, new Vector3(15, 6, 1)); // ������ ũ��� ��ġ�� ����
    }
}
