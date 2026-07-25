using Natrix.Core.RenderRoot;

namespace Natrix.Core.Components;

public interface IComponent
{
    void Mount(IRenderSlot slot);
    void Unmount();
}