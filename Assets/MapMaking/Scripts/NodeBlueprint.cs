using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Map
{
    public enum NodeType
    {
        Battle,
        RestPlace,
        Event,
        Treasure,
        Friend,
        Boss
    }

    [CreateAssetMenu(fileName = "nodeData", menuName = "Scriptble Object/NodeData")]
    public class NodeBluePrint : ScriptableObject
    {
        public Sprite sprite;
        public NodeType nodetype;
    }
}
