using System.Collections.Generic;

namespace DotSpatial.Topology.Geometries.Utilities
{
    ///<summary>
    /// Extracts a single representative <see cref="Coordinate"/> from each connected component of a <see cref="IGeometry"/>.
    ///</summary>
    /// <version>1.9</version>
    public class ComponentCoordinateExtracter : IGeometryComponentFilter
    {
        #region Fields

        private readonly List<Coordinate> _coords;

        #endregion

        #region Constructors

        ///<summary>
        /// Constructs a LineExtracterFilter with a list in which to store LineStrings found.
        ///</summary>
        public ComponentCoordinateExtracter(List<Coordinate> coords)
        {
            _coords = coords;
        }

        #endregion

        #region Methods

        public void Filter(IGeometry geom)
        {
            // add coordinates from connected components
            if (geom is ILineString
                || geom is IPoint)
                _coords.Add(geom.Coordinate);
        }

        ///<summary>
        /// Extracts the linear components from a single geometry.
        /// If more than one geometry is to be processed, it is more
        /// efficient to create a single <see cref="ComponentCoordinateExtracter"/> instance
        /// and pass it to multiple geometries.
        ///</summary>
        /// <param name="geom">The Geometry from which to extract</param>
        /// <returns>A list of Coordinates</returns>
        public static List<Coordinate> GetCoordinates(IGeometry geom)
        {
            var coords = new List<Coordinate>();
            geom.Apply(new ComponentCoordinateExtracter(coords));
            return coords;
        }

        #endregion
    }
}