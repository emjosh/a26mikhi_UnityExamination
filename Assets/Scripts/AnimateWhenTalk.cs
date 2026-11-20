using UnityEngine;

public class AnimateWhenTalk : MonoBehaviour
{
    [SerializeField] Animator skellyAnimator;
    
    public void TalkAnimation()
    {
        skellyAnimator.SetBool("Talk", true);
    }
    
    
}
