
namespace RealWorldClasses.Electronics.Switches
{
    // three pin, second one for small power source to activate switch
    public class SinglePoleSingleThrow : Switch
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public SinglePoleSingleThrow() : base()
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public SinglePoleSingleThrow(Link link) : base(link)
        {
        }
    }
}