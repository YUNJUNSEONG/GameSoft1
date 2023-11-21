using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject roomPrefab; // Prefab for the room game object
    public GameObject pathPrefab; // Prefab for the path game object
    public int gridWidth = 7;
    public int gridHeight = 15;

    private List<List<GameObject>> mapGrid;

    void Start()
    {
        GenerateMap();
    }

    void GenerateMap()
    {
        // Initialize the map grid
        mapGrid = new List<List<GameObject>>();

        // Generate rooms
        for (int x = 0; x < gridWidth; x++)
        {
            List<GameObject> column = new List<GameObject>();

            for (int y = 0; y < gridHeight; y++)
            {
                Vector3 position = new Vector3(x, 0, y);
                GameObject room = Instantiate(roomPrefab, position, Quaternion.identity);
                column.Add(room);
            }

            mapGrid.Add(column);
        }

        // Generate paths
        for (int x = 0; x < gridWidth - 1; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                ConnectRooms(mapGrid[x][y], mapGrid[x + 1][y]);
            }
        }

        // Generate additional paths (randomly connecting floors)
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight - 1; y++)
            {
                if (Random.Range(0f, 1f) < 0.5f)
                {
                    ConnectRooms(mapGrid[x][y], mapGrid[x][y + 1]);
                }
            }
        }
    }

    void ConnectRooms(GameObject room1, GameObject room2)
    {
        // Instantiate a path between two rooms
        Vector3 pathPosition = (room1.transform.position + room2.transform.position) / 2f;
        GameObject path = Instantiate(pathPrefab, pathPosition, Quaternion.identity);

        // Additional logic for handling the connection between rooms
        // (e.g., adjusting doors, setting room attributes, etc.)
    }
}
