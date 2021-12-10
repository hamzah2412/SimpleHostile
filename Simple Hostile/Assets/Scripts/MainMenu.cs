using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.Kawaiisun.SimpleHostile
{
    public class MainMenu : MonoBehaviour
    {
        public Launcher launcher;

        private void Start()
        {
            Pause.paused = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        public void JoinMatch()
        {
            launcher.Join();
        }

        public void CreateMatch()
        {
            launcher.Create();
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        public void CreditScene()
        {
            SceneManager.LoadScene("Credits");
        }

        public void MainMenuScene()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
