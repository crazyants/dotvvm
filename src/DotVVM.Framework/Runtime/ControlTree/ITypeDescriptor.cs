using DotVVM.Framework.Controls;

namespace DotVVM.Framework.Runtime.ControlTree
{
    public interface ITypeDescriptor
    {

        string Name { get; }

        string Namespace { get; }

        string Assembly { get; }

        string FullName { get; }

        bool IsAssignableTo(ITypeDescriptor typeDescriptor);

        bool IsAssignableFrom(ITypeDescriptor typeDescriptor);

        ControlMarkupOptionsAttribute GetControlMarkupOptionsAttribute();

        bool IsEqualTo(ITypeDescriptor other);
    }
}