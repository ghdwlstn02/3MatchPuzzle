using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Vector3 strength = new Vector3(0.1f, 0.1f, 0.1f); //punch 강도 줄이기 위함

        transform.DOPunchScale(strength, 1f); //punch, duration = 크기 효과, 효과 지속 시간
    }
}
