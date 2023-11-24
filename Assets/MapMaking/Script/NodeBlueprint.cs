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
        Event  // 6������ ��� ���� ����
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