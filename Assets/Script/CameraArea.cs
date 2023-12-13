using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArea : MonoBehaviour
{
    // 플레이어
    public Transform map;

    // 카메라 이동 속도
    public float cameraSpeed;

    // 카메라 제한 영역의 위치와 크기
    public Vector2 areaCenter, areaSize;

    // 카메라의 세로/가로 절반 길이
    float heightHalf, widthHalf;

    float distX; // 가로 제한 범위
    float distY; // 세로 제한 범위

    private void Start()
    {
        // 카메라의 세로 절반 길이 가져오기
        heightHalf = Camera.main.orthographicSize;

        // 카메라의 가로 절반 길이 구하기
        widthHalf = heightHalf * Screen.width / Screen.height;

        // 가로/세로 제한 범위 구하기
        distX = areaSize.x * 0.5f - widthHalf;
        distY = areaSize.y * 0.5f - heightHalf;
    }

    void LateUpdate() // 업데이트가 끝나자마자 호출
    {
        // 플레이어의 x,y를 가져오기
        Vector3 target = new Vector3(map.position.x, map.position.y, transform.position.z);

        // 플레이어의 위치로 서서히 이동
        transform.position = Vector3.Lerp(transform.position, target, cameraSpeed * Time.deltaTime);

        // XY 제한
        float clampX = Mathf.Clamp(transform.position.x, areaCenter.x - distX, areaCenter.x + distX);
        float clampY = Mathf.Clamp(transform.position.y, areaCenter.y - distY, areaCenter.y + distY);

        // 카메라에 제한 적용
        transform.position = new Vector3(clampX, clampY, -10);
    }

    private void OnDrawGizmos()
    {
        // 기즈모 색상 노란색
        Gizmos.color = Color.yellow;

        // 카메라 제한 영역 그리기
        Gizmos.DrawWireCube(areaCenter, areaSize);
    }
}

