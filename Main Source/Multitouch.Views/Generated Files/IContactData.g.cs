//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3069
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts
{
    
    public interface IContactData
    {
        int Id
        {
            get;
        }
        System.Windows.Rect Bounds
        {
            get;
        }
        System.Windows.Point Position
        {
            get;
        }
        double Orientation
        {
            get;
        }
        double Area
        {
            get;
        }
        double MajorAxis
        {
            get;
        }
        double MinorAxis
        {
            get;
        }
        ContactState State
        {
            get;
        }
    }
}
