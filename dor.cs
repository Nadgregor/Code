using UnityEngine;
using System.Collections;

public class dor : MonoBehaviour
{

    [SerializeField] private bool doorOpen = false;
    [SerializeField] private Animator axen = null;
    private float animationFinished = 0;

    public void OnMouseUp()
    {
        Debug.Log("Ive been clicked");

        if (Time.time > animationFinished)
        {
            if (doorOpen)
            {

                axen.Play("axe", 0, 0.0f);
                
            }
            

            animationFinished = Time.time + 1;
            doorOpen = !doorOpen;
        }
    }
}