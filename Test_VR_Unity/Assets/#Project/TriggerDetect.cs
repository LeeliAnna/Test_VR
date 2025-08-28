using UnityEngine;

public class TriggerDetect : MonoBehaviour
{
    //rend la variable visible même si elle est privée
    [SerializeField] private string tagName;

    void OnTriggerEnter(Collider other)
    {
        // verifier si l'objet entrer en collision porte un tag ici "Detect" possible avec un ou de gerer plusieurs tags
        if (other.CompareTag(tagName))
        {
            Debug.Log($"Coucou {other.name}");
        }
    }
}
