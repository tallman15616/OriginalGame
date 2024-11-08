using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_animation : MonoBehaviour
{
    //NPC�̑��郂�[�V�����ɂ�SE������X�N���v�g
    public AudioClip[] FootstepAudioClips;
    [Range(0, 1)] public float FootstepAudioVolume = 0.5f;
    private void OnFootstep(AnimationEvent animationEvent)
    {
        //�A�j���[�V�����N���b�v�̃E�F�C�g��0.5�����傫���Ȃ�
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            //FootstepAudioClips�̗v�f����1�ł�����Ɩ炷
            if (FootstepAudioClips.Length > 0)
            {
                var index = Random.Range(0, FootstepAudioClips.Length);
                AudioSource.PlayClipAtPoint(FootstepAudioClips[index], transform.position, FootstepAudioVolume);
            }
        }
    }
}
