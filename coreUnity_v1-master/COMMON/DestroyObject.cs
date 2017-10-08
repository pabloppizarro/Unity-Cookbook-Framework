using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour
{
    public float timeBeforeObjectDestroys;
    void Start()
    {
        // the function destroyGO() will be called in // timeBeforeObjectDestroys seconds
        Invoke("DestroyGO", timeBeforeObjectDestroys);
    }
    void DestroyGO()
    {
        // destroy this gameObject
        Destroy(gameObject);
    }
}   