using UnityEngine;

namespace Dev.ComradeVanti.WaitForAnim
{

    public static class AnimatorExt
    {

        /// <summary>
        ///     Plays an animation and returns a yield-instruction that finishes when
        ///     the animation is done
        /// </summary>
        /// <param name="animator">The animator to play on</param>
        /// <param name="animationName">The name of the animation</param>
        /// <param name="layer">The animation-layer</param>
        /// <returns>The yield-instruction</returns>
        public static WaitForAnimationToFinish PlayAndWait(this Animator animator, string animationName, int layer = 0)
        {
            animator.Play(animationName, layer);
            return new WaitForAnimationToFinish(animator, animationName, layer);
        }

    }

}