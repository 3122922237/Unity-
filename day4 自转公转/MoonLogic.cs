using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** �˽ű�����������
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

        // �ҵ�������
        Transform parent = this.transform.parent;

        // ���Ƹ�������ת
        parent.Rotate(0, rotateSpeed* Time.deltaTime, 0, Space.Self);
    }
}
