namespace BaristaLabs.ChromeDevTools.Animation
{
    /// <summary>
    /// Event for when an animation has been cancelled.
    /// </summary>
    public sealed class AnimationCanceledEvent
    {
    
        
        /// <summary>
        /// Id of the animation that was cancelled.
        /// </summary>
        
        public string Id
        {
            get;
            set;
        }
    
    }
}