using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using SimpleJSON;

public class RestAPI_Prueba : MonoBehaviour
{
    private string URL = "https://kevincampos.cl/api/v1/ubicacion";

    public Text id;
    public Text nombre;
    public Text descriocion;
    public Text description_large;
    public Text nombre_localizacion;
    public Text tipo;
    public Text imagen;
    public Text latitud;
    public Text longitud;
    public Text codigo;
    public Text icono_primario;
    public Text icono_secundario;
    public Text icono_terciario;
    public Text created_at;
    public Text update_at;
    public Text id_institucion;
    public int index;

    void Start()
    {
        StartCoroutine(getDatas());
    }

    IEnumerator getDatas()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(URL))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError(request.error);
            }
            else
            {
                string json = request.downloadHandler.text;
                JSONNode stats = JSONNode.Parse(json);


                id.text = "id: " + stats[index]["id"];
                Debug.Log(id.text);

                nombre.text = "nombre: " + stats[index]["nombre"];
                Debug.Log(nombre.text);


                descriocion.text = "descripcion: " + stats[index]["descriocion"];
                Debug.Log(descriocion.text);

                description_large.text = "description_large: " + stats[index]["description_large"];
                Debug.Log(description_large.text);

                nombre_localizacion.text = "nombre_localizacion: " + stats[index]["nombre_localizacion"];
                Debug.Log(nombre_localizacion.text);

                tipo.text = "tipo: " + stats[index]["tipo"];
                Debug.Log(tipo.text);

                imagen.text = "imagen: " + stats[index]["imagen"];
                Debug.Log(imagen.text);

                latitud.text = "latitud: " + stats[index]["latitud"];
                Debug.Log(latitud.text);

                longitud.text = "longitud: " + stats[index]["longitud"];
                Debug.Log(longitud.text);

                codigo.text = "codigo: " + stats[index]["codigo"];
                Debug.Log(codigo.text);

                icono_primario.text = "icono_primario: " + stats[index]["icono_primario"];
                Debug.Log(icono_primario.text);

                icono_secundario.text = "icono_secundario: " + stats[index]["icono_secundario"];
                Debug.Log(icono_secundario.text);

                icono_terciario.text = "icono_terciario: " + stats[index]["icono_terciario"];
                Debug.Log(icono_terciario.text);

                created_at.text = "created_at: " + stats[index]["created_at"];
                Debug.Log(created_at.text);

                update_at.text = "update_at: " + stats[index]["update_at"];
                Debug.Log(update_at.text);

                id_institucion.text = "id_institucion: " + stats[index]["id_institucion"];
                Debug.Log(id_institucion.text);
            }
        }
    }
}
