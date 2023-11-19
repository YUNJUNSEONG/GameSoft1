using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject roomPrefab; // 방을 나타내는 프리팹
    public Material roomMaterial; // 방의 머티리얼

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
            // 방 생성
            GameObject newRoom = Instantiate(roomPrefab, new Vector3(x, floorNumber, 0), Quaternion.identity);

            // 방에 Renderer 컴포넌트가 없으면 추가
            Renderer roomRenderer = newRoom.GetComponent<Renderer>();
            if (roomRenderer == null)
            {
                roomRenderer = newRoom.AddComponent<Renderer>();
            }

            // 방의 머티리얼 설정
            if (roomMaterial != null)
            {
                roomRenderer.material = roomMaterial;
            }

            // 무작위 색상 생성 및 설정
            Color randomColor = Random.ColorHSV();
            roomRenderer.material.color = randomColor;
        }
    }

    // OnDrawGizmos 메서드를 추가하여 Gizmo를 설정
    void OnDrawGizmos()
    {
        Gizmos.color = Color.black; // 원하는 색상으로 설정

        // Gizmo를 통해 시각적으로 확인할 내용 추가
        Gizmos.DrawLine(transform.position, new Vector3(15, 6, 1)); // 적절한 크기와 위치로 수정
    }
}
