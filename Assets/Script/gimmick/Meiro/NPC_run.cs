using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class NPC_run : MonoBehaviour
{
    //NPCがplayerを追いかけるスクリプト
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
        //playerがオンの時、追いかける
        if (target)
        {
            agent.destination = target.transform.position;
        }
    }

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
