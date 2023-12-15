using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Networking;
using System.Linq;

public class DatabaseManager : MonoBehaviour
{
    string username;
    string password;
    string uri;
    string uriGet;
    string contentType = "application/json";


    public WinCondition levelData;
    public QuestionsMenuManager qManager;

    private void Awake()
    {
        LoadCredentials();
    }
    void Update()
    {
        if (qManager != null && qManager.send)
        {
            StartCoroutine(SendPostRequestUsuario());
            qManager.send = false;
        }
        if (levelData != null && levelData.send)
        {
            string tableUsuarios = "Usuarios";
            string data = CreateJSON(tableUsuarios);
            StartCoroutine(SendGetRequest(data));
            levelData.send = false;
        }
    }

    string CreateJSONUsuario(string tabla, int edad, string genero)
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

    string CreateJSONDatosNiveles(string tabla, int id, int nivel, string movimientos, string tiempo)
    {
        //UnityEngine.Debug.Log("Level: " + nivel + "movs: " + movimientos + "time: " + tiempo);
        //Construye JSON para la petición REST         
        string json = $@"{{
            ""username"":""{username}"",
            ""password"":""{password}"",
            ""table"":""{tabla}"",
            ""data"": {{
		        ""UsuarioID"":""{id}"",
                ""Nivel"": ""{nivel}"",
                ""Movimientos"": ""{movimientos}"",
                ""TiempoResolucion"": ""{tiempo}""
            }}
        }}";

        return json;
    }


    string CreateJSON(string tabla)
    {
        string json = $@"{{
            ""username"":""{username}"",
            ""password"":""{password}"",
            ""table"":""{tabla}"",
            ""filter"":{{
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

    IEnumerator SendPostRequestNivel(int id)
    {
        if (levelData != null)
        {

            string datosNiveles = CreateJSONDatosNiveles("DatosNiveles", id, levelData.currentLevel, levelData.movementString, levelData.timeString);

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


    IEnumerator SendGetRequest(string data)
    {
        UnityEngine.Debug.Log("entro get request");
        UnityEngine.Debug.Log("Data: " + data);

        using (UnityWebRequest www = UnityWebRequest.Post(uriGet, data, contentType))
        {
            yield return www.SendWebRequest();
            print("entro en el using");

            if (www.result != UnityWebRequest.Result.Success)
            {
                print("Error: " + www.error);
            }
            else
            {
                print("Respuesta: " + www.downloadHandler.text);
                string answer = www.downloadHandler.text;
                // Procesa la respuesta para obtener el último ID
                LastInsertedIDResponse response = JsonUtility.FromJson<LastInsertedIDResponse>(answer);
                if (response.data != null && response.data.Count > 0)
                {
                    // Encuentra el UsuarioID más grande 
                    int maxId = response.data.Max(item => item.UsuarioID);

                    if (maxId > 0)
                    {
                        //id = maxUserID;
                        print("Último ID insertado: " + maxId);
                        StartCoroutine(SendPostRequestNivel(maxId));
                    }
                    else
                    {
                        print("No se encontraron UsuarioID válidos en la respuesta.");
                    }
                }
                else
                {
                    print("No se encontraron datos en la respuesta.");
                }

            }
        }
    }


    void LoadCredentials()
    {
        TextAsset configData = Resources.Load<TextAsset>("configBuild");

        if (Application.isEditor)
        {
            configData = Resources.Load<TextAsset>("config");
        }

        if (configData != null)
        {

            var config = JsonUtility.FromJson<Credentials>(configData.text);

            username = config.username;
            password = config.password;
            uri = config.uri;
            uriGet = config.uriGet;
        }
        else
        {
            UnityEngine.Debug.LogError("Config file not found!");
        }
    }

    [System.Serializable]
    private class Credentials
    {
        public string username;
        public string password;
        public string uri;
        public string uriGet;
    }

    [System.Serializable]
    private class LastInsertedIDResponse
    {
        public string result;
        public List<UserData> data;

        [System.Serializable]
        public class UserData
        {
            public int UsuarioID;
            public int Edad;
            public string Genero;
        }
    }
}