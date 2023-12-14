using System.Collections;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Networking;

public class DatabaseManager : MonoBehaviour
{
    string username;
    string password;
    string uri;
    string contentType = "application/json";

    public WinCondition levelData;
    public QuestionsMenuManager qManager;

    private void Awake()
    {
        LoadCredentials();
    }
    void Update()
    {
        if(qManager != null && qManager.send )
        {
            StartCoroutine(SendPostRequestUsuario());
            qManager.send = false;
        }
        if (levelData != null && levelData.send)
        {
            StartCoroutine(SendPostRequestNivel());
            levelData.send = false;
        }
    }

    string CreateJSONUsuario(string tabla,int edad, string genero)
    {
        //Construye JSON para la petición REST         
        string json = $@"{{
            ""username"":""{username}"",
            ""password"":""{password}"",
            ""table"":""{tabla}"",
            ""data"": {{
                ""Edad"": ""{edad}"",
                ""Genero"": ""{genero}""
            }}
        }}";

        return json;
    }

    string CreateJSONDatosNiveles(string tabla, int nivel, string movimientos, string tiempo)
    {
        Debug.Log("Level: " + nivel + "movs: " + movimientos + "time: " + tiempo);
        //Construye JSON para la petición REST         
        string json = $@"{{
            ""username"":""{username}"",
            ""password"":""{password}"",
            ""table"":""{tabla}"",
            ""data"": {{
                ""Nivel"": ""{nivel}"",
                ""Movimientos"": ""{movimientos}"",
                ""TiempoResolucion"": ""{tiempo}""
            }}
        }}";

        return json;
    }

  

    IEnumerator SendPostRequestUsuario()
    {
        if (qManager != null)
        {
            string usuarios = CreateJSONUsuario("Usuarios", qManager.value, qManager.gender);
            using (UnityWebRequest www = UnityWebRequest.Post(uri, usuarios, contentType))
            {
                yield return www.SendWebRequest();

                if (www.result != UnityWebRequest.Result.Success)
                {
                    print("Error: " + www.error);
                }
                else
                {
                    print("Respuesta: " + www.downloadHandler.text);
                }
            }
        }        
       
    }

    IEnumerator SendPostRequestNivel()
    {
        if (levelData != null)
        {
            string datosNiveles = CreateJSONDatosNiveles("DatosNiveles", levelData.currentLevel, levelData.movementString, levelData.timeString);

            using (UnityWebRequest www = UnityWebRequest.Post(uri, datosNiveles, contentType))
            {
                yield return www.SendWebRequest();

                if (www.result != UnityWebRequest.Result.Success)
                {
                    print("Error: " + www.error);
                }
                else
                {
                    print("Respuesta: " + www.downloadHandler.text);
                }
            }
        }

    }

    void LoadCredentials()
    {
        string configPath = "Assets/config.json";

        if (File.Exists(configPath))
        {
            string configJson = File.ReadAllText(configPath);
            var config = JsonUtility.FromJson<Credentials>(configJson);

            username = config.username;
            password = config.password;
            uri = config.uri;
        }
        else
        {
            Debug.LogError("Config file not found!");
        }
    }

    [System.Serializable]
    private class Credentials
    {
        public string username;
        public string password;
        public string uri;
    }
}
