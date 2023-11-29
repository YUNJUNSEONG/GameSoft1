using Newtonsoft.Json;
using System.Linq;
using UnityEngine;

namespace Map
{
    public class MapManager : MonoBehaviour
    {
        public MapConfig config;
        public MapView view;

        public Map CurrentMap { get; private set; }

        void Start()
        {
            if (PlayerPrefs.HasKey("Map"))
            {
                var mapJson = PlayerPrefs.GetString("Map");
                var map = JsonConvert.DeserializeObject<Map>(mapJson);
                if (map.path.Any(p => p.Equals(map.GetBossNode().point)))
                {
                    GenerateNewMap();
                }
                else
                {
                    CurrentMap = map;
                    view.ShowMap(map);
                }
            }
            else
            {
                GenerateNewMap();
            }
        }

        public void GenerateNewMap()
        {
            var map = MapGenerator.GetMap(config);
            CurrentMap = map;
            Debug.Log(map.ToJson());
            view.ShowMap(map);
        }

        public void SaveMap()
        {
            if (CurrentMap == null) return;

            var json = JsonConvert.SerializeObject(CurrentMap, Formatting.Indented,
                new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            PlayerPrefs.SetString("Map", json);
            PlayerPrefs.Save();
        }

        private void OnApplicationQuit()
        {
            SaveMap();
        }
    }
}
