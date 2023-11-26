using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Map
{
    public class DottedLineRenderer : MonoBehaviour
    {
        public bool scalelnUpdate = false;
        private LineRenderer IR;
        private Renderer rend;
        // Start is called before the first frame update
        void Start()
        {
            ScaleMaterial();
            enabled = scalelnUpdate;
        }

        public void ScaleMaterial()
        {
            IR = GetComponent<LineRenderer>();
            rend = GetComponent<Renderer>();
            rend.material.mainTextureScale =
                new Vector2(Vector2.Distance(IR.GetPosition(0), IR.GetPosition(IR.positionCount - 1)) / IR.widthMultiplier, 1);
        }
        // Update is called once per frame
        void Update()
        {
            rend.material.mainTextureScale =
                new Vector2(Vector2.Distance(IR.GetPosition(0), IR.GetPosition(IR.positionCount - 1)) / IR.widthMultiplier, 1);
        }
    }
}
