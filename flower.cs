using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower : MonoBehaviour
{
    public float n,d,scale,times;
    float k;
    float theta;
    float r, x, y;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        k = n / d;
        r = Mathf.Cos(k * theta)*scale;
        x = r*Mathf.Cos(theta);
        y = r*Mathf.Sin(theta);

        transform.position = new Vector3(x*20, y*20, 0);
        
        theta += times*0.1f * Time.deltaTime;
        if (theta > 9223372036854775295) theta = 0f;
        if(theta < 0.1f*times)
        {
            gameObject.GetComponent<TrailRenderer>().enabled = false;
        }
        else gameObject.GetComponent<TrailRenderer>().enabled = true;

    }
}
