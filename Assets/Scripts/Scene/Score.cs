using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class Score : MonoBehaviour
    {
        public static int ScoreGame = 0;
        public static string _Level;

        public string CurrentLevel;

        private void Start()
        {
            _Level = CurrentLevel;
            AudioManager.ChangeScene = true;
        }

        private void Update()
        {
            if (ScoreGame <= 0)
            {
                ScoreGame = 0;
            }
        }
    }
}