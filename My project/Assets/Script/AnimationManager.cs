using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private int count = 0;
    private float speed = 10.0f;
    [SerializeField] Animator[] animator;

    public void SpeedSetting()
    {
        if (speed++ >= 10)
        {
            speed = 1;
        }
        for (int i = 0; i < animator.Length; i++)
        {
                animator[i].speed = speed / 10;
        }
    }
    
    public void LayerMaskSetting(int layerIndex)
    {
        count = count % 2;

        switch(count++)
        {
            case 0: Camera.main.cullingMask = ~(1 << layerIndex);
                break;
            case 1: Camera.main.cullingMask = -1;       
                break;
        }
    }
}


