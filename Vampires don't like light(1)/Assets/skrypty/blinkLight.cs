using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinkLight : MonoBehaviour
{
    public float phase1Duration = 3f;  
    public float phase2Duration = 3f;  
    public BoxCollider2D box;
    public SpriteRenderer sr;

    private void Start()
    {
        StartCoroutine(CyclePhases());
    }

    private IEnumerator CyclePhases()
    {
        while (true) 
        {
           
            box.enabled = true;
            sr.enabled = true;
            yield return new WaitForSeconds(phase1Duration);  

            box.enabled = false;
            sr.enabled = false;
            yield return new WaitForSeconds(phase2Duration);  
        }
    }
}