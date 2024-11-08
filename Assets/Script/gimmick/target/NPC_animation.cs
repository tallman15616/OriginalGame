using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_animation : MonoBehaviour
{
    //NPCの走るモーションににSEをつけるスクリプト
    public AudioClip[] FootstepAudioClips;
    [Range(0, 1)] public float FootstepAudioVolume = 0.5f;
    private void OnFootstep(AnimationEvent animationEvent)
    {
        //アニメーションクリップのウェイトが0.5ｆより大きくなる
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            //FootstepAudioClipsの要素数が1つでもあると鳴らす
            if (FootstepAudioClips.Length > 0)
            {
                var index = Random.Range(0, FootstepAudioClips.Length);
                AudioSource.PlayClipAtPoint(FootstepAudioClips[index], transform.position, FootstepAudioVolume);
            }
        }
    }
}
