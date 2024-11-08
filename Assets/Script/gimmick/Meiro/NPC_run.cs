using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class NPC_run : MonoBehaviour
{
    //NPC��player��ǂ�������X�N���v�g
    public GameObject target;
    private NavMeshAgent agent;
    public AudioClip[] FootstepAudioClips;
    [Range(0, 1)] public float FootstepAudioVolume = 0.5f;
    public bool onGround = true;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        //player���I���̎��A�ǂ�������
        if (target)
        {
            agent.destination = target.transform.position;
        }
    }

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
