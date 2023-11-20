using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralMapGenerator : MonoBehaviour
{
    public int rows = 7;
    public int columns = 15;
    public int numIterations = 6;

    void OnDrawGizmos()
    {
        GenerateMap();
    }

    void GenerateMap()
    {
        for (int iteration = 0; iteration < numIterations; iteration++)
        {
            // 각 반복에 대한 랜덤 시드 설정
            Random.InitState(iteration);

            // 15x7 크기의 격자 생성
            for (int column = 0; column < columns; column++)
            {
                // 현재 위치
                Vector3 currentPos = new Vector3(column, iteration, 0);

                // 현재 층의 방 표시 (투명한 사각형)
                Gizmos.DrawCube(currentPos, Vector3.one);

                // 다음 층의 방 선택
                int nextColumn = column + Random.Range(-1, 2);
                nextColumn = Mathf.Clamp(nextColumn, 0, columns - 1);

                // 다음 층의 방 표시 (선)
                Vector3 nextPos = new Vector3(nextColumn, iteration + 1, 0);
                Gizmos.DrawLine(currentPos, nextPos);
            }
        }
    }
}

