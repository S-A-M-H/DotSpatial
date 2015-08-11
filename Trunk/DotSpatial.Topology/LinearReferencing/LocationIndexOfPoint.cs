using System;
using DotSpatial.Topology.Geometries;
using DotSpatial.Topology.Utilities;

namespace DotSpatial.Topology.LinearReferencing
{
    /// <summary>
    /// Computes the <see cref="LinearLocation" /> of the point
    /// on a linear <see cref="Geometry" />nearest a given <see cref="Coordinate"/>.
    /// The nearest point is not necessarily unique; this class
    /// always computes the nearest point closest
    /// to the start of the geometry.
    /// </summary>
    public class LocationIndexOfPoint
    {
        #region Fields

        private readonly IGeometry _linearGeom;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationIndexOfPoint"/> class.
        /// </summary>
        /// <param name="linearGeom">A linear geometry.</param>
        public LocationIndexOfPoint(IGeometry linearGeom)
        {
            _linearGeom = linearGeom;
        }

        #endregion

        #region Methods

        /// <summary>
        ///
        /// </summary>
        /// <param name="linearGeom"></param>
        /// <param name="inputPt"></param>
        /// <returns></returns>
        public static LinearLocation IndexOf(IGeometry linearGeom, Coordinate inputPt)
        {
            var locater = new LocationIndexOfPoint(linearGeom);
            return locater.IndexOf(inputPt);
        }

        /// <summary>
        /// Find the nearest location along a linear <see cref="Geometry" /> to a given point.
        /// </summary>
        /// <param name="inputPt">The coordinate to locate.</param>
        /// <returns>The location of the nearest point.</returns>
        public LinearLocation IndexOf(Coordinate inputPt)
        {
            return IndexOfFromStart(inputPt, null);
        }

        public static LinearLocation IndexOfAfter(IGeometry linearGeom, Coordinate inputPt, LinearLocation minIndex)
        {
            var locater = new LocationIndexOfPoint(linearGeom);
            return locater.IndexOfAfter(inputPt, minIndex);
        }

        /// <summary>
        /// Find the nearest <see cref="LinearLocation" /> along the linear <see cref="Geometry" />
        /// to a given <see cref="Geometry" /> after the specified minimum <see cref="LinearLocation" />.
        /// If possible the location returned will be strictly greater than the <paramref name="minIndex" />.
        /// If this is not possible, the value returned will equal <paramref name="minIndex" />.
        /// (An example where this is not possible is when <paramref name="minIndex" /> = [end of line] ).
        /// </summary>
        /// <param name="inputPt">The coordinate to locate.</param>
        /// <param name="minIndex">The minimum location for the point location.</param>
        /// <returns>The location of the nearest point.</returns>
        public LinearLocation IndexOfAfter(Coordinate inputPt, LinearLocation minIndex)
        {
            if (minIndex == null)
                return IndexOf(inputPt);

            // sanity check for minLocation at or past end of line
            var endLoc = LinearLocation.GetEndLocation(_linearGeom);
            if (endLoc.CompareTo(minIndex) <= 0)
                return endLoc;

            var closestAfter = IndexOfFromStart(inputPt, minIndex);

            /*
             * Return the minDistanceLocation found.
             * This will not be null, since it was initialized to minLocation
             */
            Assert.IsTrue(closestAfter.CompareTo(minIndex) >= 0, "computed location is before specified minimum location");
            return closestAfter;
        }

        private LinearLocation IndexOfFromStart(Coordinate inputPt, LinearLocation minIndex)
        {
            var minDistance = Double.MaxValue;
            var minComponentIndex = 0;
            var minSegmentIndex = 0;
            var minFrac = -1.0;

            var seg = new LineSegment();
            for (var it = new LinearIterator(_linearGeom);
                 it.HasNext(); it.Next())
            {
                if (!it.IsEndOfLine)
                {
                    seg.P0 = it.SegmentStart;
                    seg.P1 = it.SegmentEnd;
                    var segDistance = seg.Distance(inputPt);
                    var segFrac = seg.SegmentFraction(inputPt);

                    var candidateComponentIndex = it.ComponentIndex;
                    var candidateSegmentIndex = it.VertexIndex;
                    if (segDistance < minDistance)
                    {
                        // ensure after minLocation, if any
                        if (minIndex == null ||
                            minIndex.CompareLocationValues(candidateComponentIndex, candidateSegmentIndex, segFrac) < 0)
                        {
                            // otherwise, save this as new minimum
                            minComponentIndex = candidateComponentIndex;
                            minSegmentIndex = candidateSegmentIndex;
                            minFrac = segFrac;
                            minDistance = segDistance;
                        }
                    }
                }
            }

            if (minDistance == Double.MaxValue)
            {
                // no minimum was found past minLocation, so return it
                return new LinearLocation(minIndex);
            }
            // otherwise, return computed location
            var loc = new LinearLocation(minComponentIndex, minSegmentIndex, minFrac);
            return loc;
        }

        #endregion
    }
}