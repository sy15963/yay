using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public GameObject window;


    // Update is called once per frame
    void Update()
    {    // 애니메이터 컨트롤러에서 현재 애니메이터의 상태의 이름이 "Close" 이면
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            // 현재 애니메이션의 진행도가 1보다 크거나 같다면 User Interface를 비활성화합니다.
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
               window.SetActive(false);
            }
        }
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }

    public void PopUpOpen()
    {
        window.SetActive(true);
    }
}


