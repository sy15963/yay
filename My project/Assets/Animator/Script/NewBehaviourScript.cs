using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public interface IFunction
{
    // interface�� �Ϲ����� ������ ������ �� ����
    public void Damage();
}

public class NewBehaviourScript : MonoBehaviour
{
    public int data = 5;
    float degree = 0;

    public void Damage()
    {
        Debug.Log("Damage�� ȣ��Ǿ����ϴ�.");
    }

    void Start()
    {
        Damage();
        Debug.Log("data ������ �� : " + data);
    }

    private void Update()
    {
        degree += Time.deltaTime;

        if (degree >= 360)
            degree = 0;

        RenderSettings.skybox.SetFloat("_Rotation", degree);
    }
}
