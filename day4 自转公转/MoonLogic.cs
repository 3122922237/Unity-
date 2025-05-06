using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 此脚本挂在卫星上
 * 
 */
public class MoonLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateSpeed = 60;

        // 找到父物体
        Transform parent = this.transform.parent;

        // 控制父物体旋转
        parent.Rotate(0, rotateSpeed* Time.deltaTime, 0, Space.Self);
    }
}
