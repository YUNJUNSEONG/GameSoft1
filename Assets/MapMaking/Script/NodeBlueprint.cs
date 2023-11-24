using UnityEngine;

namespace Map
{
    public enum NodeType
    {
        Battle,
        Freind,
        RestPlace,
        Treasure,
        Boss,
        Event  // 6가지의 노드 종류 생성
    }
}

namespace Map
{
    [CreateAssetMenu]
    public class NodeBlueprint : ScriptableObject
    {
        public Sprite sprite;
        public NodeType nodeType;
    }
}