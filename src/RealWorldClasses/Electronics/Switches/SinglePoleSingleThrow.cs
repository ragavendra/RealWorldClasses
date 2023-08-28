
namespace RealWorldClasses.Electronics.Switches
{
    // three pin, second one for small power source to activate switch
    public class SinglePoleSingleThrow : Switch
    {
        public SinglePoleSingleThrow() : base()
        {
        }

        public SinglePoleSingleThrow(Link link) : base(link)
        {
        }
    }
}