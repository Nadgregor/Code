using UnityEngine;

public class zus : MonoBehaviour
{



    [SerializeField] private GameObject hand;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        
        {
            other.transform.position = new Vector3(-24, 2, -16);
        }
    }

}