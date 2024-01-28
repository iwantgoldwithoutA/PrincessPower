using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEff : MonoBehaviour
{
    // Start is called before the first frame update
    public void EndAnimDestroy() 
    {
        Destroy(this.gameObject);
    }
}
