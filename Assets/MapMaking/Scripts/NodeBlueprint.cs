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
}

namespace Map
{
    [CreateAssetMenu]

    public class NodeBluePrint : ScriptableObject
    {
        public Sprite sprite;
        public NodeType nodetype;
    }
}
