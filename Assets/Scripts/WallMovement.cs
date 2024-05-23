using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour
{
    [SerializeField] float wallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Wallをマイフレーム左に1×wallSpeedだけ移動させる。
        this.gameObject.transform.position += Vector3.left * Time.deltaTime * wallSpeed;
    }
}
