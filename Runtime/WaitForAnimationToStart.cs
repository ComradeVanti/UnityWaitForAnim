using UnityEngine;

namespace Dev.ComradeVanti.WaitForAnim
{

    /// <summary>
    ///     Waits for an animation to start
    /// </summary>
    public class WaitForAnimationToStart : CustomYieldInstruction
    {

        private readonly string animationName;
        private readonly Animator animator;
        private readonly int layerIndex;


        private AnimatorStateInfo StateInfo => animator.GetCurrentAnimatorStateInfo(layerIndex);

        private bool CorrectAnimationIsPlaying => StateInfo.IsName(animationName);

        private bool AnimationStarted => StateInfo.normalizedTime > 0;

        public override bool keepWaiting => !CorrectAnimationIsPlaying || !AnimationStarted;


        /// <summary>
        ///     Creates a new yield-instruction
        /// </summary>
        /// <param name="animator">The animator to track</param>
        /// <param name="animationName">The name of the animation</param>
        /// <param name="layerIndex">The layer the animation is playing on</param>
        public WaitForAnimationToStart(Animator animator, string animationName, int layerIndex = 0)
        {
            this.animator = animator;
            this.layerIndex = layerIndex;
            this.animationName = animationName;
        }

    }

}