using System.IO;
using UnityEngine;


public class SaveManager
{
    private string path => Application.persistentDataPath + "/save.dat";

    public void SaveGame()
    {
        SaveData data = new SaveData
        {
            level = 10,
            health = 88.5f,
            playerName = "CyberIvan"
        };

        string json = JsonUtility.ToJson(data);
        string encrypted = CryptoUtils.Encrypt(json);
        File.WriteAllText(path, encrypted);
        Debug.Log("Сохранено с шифрованием.");
    }

    public void LoadGame()
    {
        if (File.Exists(path))
        {
            string encrypted = File.ReadAllText(path);
            string json = CryptoUtils.Decrypt(encrypted);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            Debug.Log($"Загружено: {data.playerName}, Уровень {data.level}, HP {data.health}");
        }
        else
        {
            Debug.Log("Сохранение не найдено.");
        }
    }
}