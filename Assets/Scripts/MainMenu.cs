using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        PlayerData.level = 0;
        PlayerData.count = 0;

        if (PlayerData.playerClass == PlayerClass.None)
        {
            PlayerClass[] values = (PlayerClass[])Enum.GetValues(typeof(PlayerClass));
            var filtered = Array.FindAll(values, v => v != PlayerClass.None);
            PlayerData.playerClass =  filtered[UnityEngine.Random.Range(0, filtered.Length)];
            PlayerData.randomClass = true;
        }
        else 
        {
            PlayerData.randomClass = false;
        }

        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame() { 
        Application.Quit();
    }
    public void SelectWarrior()
    {
        PlayerData.playerClass = PlayerClass.Warrior;
    }

    public void SelectMage()
    {
        PlayerData.playerClass = PlayerClass.Mage;
    }

    public void SelectArcher()
    {
        PlayerData.playerClass = PlayerClass.Archer;
    }
}
