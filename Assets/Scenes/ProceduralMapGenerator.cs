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
            // �� �ݺ��� ���� ���� �õ� ����
            Random.InitState(iteration);

            // 15x7 ũ���� ���� ����
            for (int column = 0; column < columns; column++)
            {
                // ���� ��ġ
                Vector3 currentPos = new Vector3(column, iteration, 0);

                // ���� ���� �� ǥ�� (������ �簢��)
                Gizmos.DrawCube(currentPos, Vector3.one);

                // ���� ���� �� ����
                int nextColumn = column + Random.Range(-1, 2);
                nextColumn = Mathf.Clamp(nextColumn, 0, columns - 1);

                // ���� ���� �� ǥ�� (��)
                Vector3 nextPos = new Vector3(nextColumn, iteration + 1, 0);
                Gizmos.DrawLine(currentPos, nextPos);
            }
        }
    }
}

