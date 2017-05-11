// ********************************************************************************************************
// Product Name: DotSpatial.Symbology.dll
// Description:  The core libraries for the DotSpatial project.
//
// ********************************************************************************************************
//
// The Original Code is DotSpatial.dll
//
// The Initial Developer of this Original Code is Ted Dunsford. Created in August, 2007.
//
// Contributor(s): (Open source contributors should list themselves and their modifications here).
//
// ********************************************************************************************************

using DotSpatial.Data;

namespace DotSpatial.Symbology
{
    /// <summary>
    /// Interface for LayerEventList.
    /// </summary>
    /// <typeparam name="T">Type of the items in the list.</typeparam>
    public interface ILayerEventList<T> : ILayerEvents, IChangeEventList<T>
        where T : ILayer
    {
    }
}