﻿using UnityEngine;
using System.Collections;

namespace RunAndJump
{

    public class BaseScene : MonoBehaviour
    {

        public enum Scene
        {
            SampleScene,
            level1,
            LevelScreen,
            LevelHandler
        }

        protected virtual void Awake()
        {
           // AudioPlayer.Instantiate();
         // Session.Instantiate();
        }

        protected void GoToScene(Scene scene)
        {
           Application.LoadLevel(scene.ToString());
        }

        protected void GoToScene(string sceneName)
        {
            Application.LoadLevel(sceneName);
        }
    }

}