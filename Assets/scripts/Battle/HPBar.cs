using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    [SerializeField] GameObject healt;

    public void SetHP(float hpNormalized)
    {
        healt.transform.localScale = new Vector3(hpNormalized, 1f);
    }
}