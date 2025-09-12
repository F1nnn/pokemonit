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

    public IEnumerator SetHPSmooth(float newHp)
    {
        float curHp = healt.transform.localScale.x;
        float changeAmt = curHp - newHp;

        while (curHp - newHp > Mathf.Epsilon)
        {
            curHp -= changeAmt * Time.deltaTime;
            healt.transform.localScale = new Vector3(curHp, 1f);
            yield return null;
        }
        healt.transform.localScale = new Vector3(newHp, 1f);
    }
}
