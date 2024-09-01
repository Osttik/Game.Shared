#nullable disable

namespace Game.Shared
{
    public class ControllerResponce<T>: ErroredResponce
    {
        public T Data { get; set; }
    }
}
