using OneLine;
using Malee;
using System.Collections.Generic;
using UnityEngine;

namespace Map
{
    [CreateAssetMenu]
    public class MapConfig : ScriptableObject
    {
        public List<NodeBluePrint> blueprints;
        public int GridWidth => Mathf.Max(numOfBossNodes.max, numOfStartingNodes.max);

        [OneLineWithHeader]
        public IntMinMax numOfBossNodes;
        [OneLineWithHeader]
        public IntMinMax numOfStartingNodes;

        [Tooltip("Increase this number to generate more paths")]
        public int extraPaths;
        [Reorderable]
        public ListOfMapLayers layers;

        [System.Serializable]
        public class ListOfMapLayers : ReorderableArray<MapLayer>
        {
        }
    }
}