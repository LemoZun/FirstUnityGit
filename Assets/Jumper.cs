using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // Start is called before the first frame update

    public float jumpPower;
    public Rigidbody rigid;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
    void Start()
    {
        
    }


}
