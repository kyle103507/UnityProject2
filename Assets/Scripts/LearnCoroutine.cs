using System.Collections.Generic;
using System.Collections;
using UnityEngine;


public class LearnCoroutine : MonoBehaviour
{
    public Transform ming;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Big());
    }

    void Update()
    {
        ming.RotateAround(Vector3.zero, Vector3.one*5, 20f );
        

    }


    public IEnumerator Big()
    {
        for (int i = 0; i < 10; i++)
        {
            ming.localScale += Vector3.one;
            yield return new WaitForSeconds(0.1f);
        }
    }


}
