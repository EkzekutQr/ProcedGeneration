using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkScript : MonoBehaviour
{
    private Transform begin;
    private Transform end;


    private void Awake()
    {
        begin = gameObject.transform.Find("Begin");
        end = gameObject.transform.Find("End");
    }
    private void Start()
    {

    }
    public Transform Begin
    {
        get
        {
            return begin;
        }
        private set { }
    }
    public Transform End
    {
        get
        {
            return end;
        }
        private set { }
    }
}
