using PLN.Drawables;
using PLN.Geometry;

namespace PLN
{
    public class SnapPointCollection
    {
        private class SnapPointEntry : IComparable<SnapPointEntry>
        {
            public readonly float Distance;
            public readonly SnapPoint SnapPoint;

            public SnapPointEntry(float distance, SnapPoint snapPoint)
            {
                Distance = distance;
                SnapPoint = snapPoint;
            }

            public int CompareTo(SnapPointEntry other)
            {
                int distCmp = Distance.CompareTo(other.Distance);
                if (distCmp == 0)
                    return ((int)SnapPoint.Type < (int)other.SnapPoint.Type ? -1 : 1);
                else
                    return distCmp;
            }
        }

        private SortedList<SnapPointEntry, bool> items = new SortedList<SnapPointEntry, bool>();
        private int currentIndex = 0;

        public bool IsEmpty { get => items.Count == 0; }

        public void Add(float distance, SnapPoint point)
        {
            items.Add(new SnapPointEntry(distance, point), false);
        }

        public void AddFromDrawable(Drawable item, Point2D cursorLocation, SnapPointType snapMode, float snapDistance)
        {
            foreach (SnapPoint pt in item.GetSnapPoints())
            {
                if ((snapMode & pt.Type) == pt.Type)
                {
                    float dist = (pt.Location - cursorLocation).Length;
                    if (dist <= snapDistance)
                    {
                        Add(dist, pt);
                    }
                }
            }
        }
        public void AddZeroPoint(Point2D cursorLocation, float snapDistance)
        {
            float dist = (Point2D.Zero - cursorLocation).Length;
            if (dist <= snapDistance)
            {
                SnapPoint pt = new SnapPoint("Origin", Point2D.Zero);
                Add(dist, pt);
            }
        }

        public void AddModulePoint(Point2D cursorLocation, float snapDistance)
        {
            float module = 100;
            float max = 10 * module;
            List<Point2D> modulePoints = new List<Point2D>();

            for (float x = -max; x <= max; x += module)
            {
                for (float y = -max; y <= max; y += module)
                {
                    modulePoints.Add(new Point2D(x, y));
                }
            }

            foreach (Point2D pt in modulePoints)
            {
                float dist = (pt - cursorLocation).Length;
                if (dist <= snapDistance)
                {
                    SnapPoint sp = new SnapPoint("Module", pt);
                    Add(dist, sp);
                }
            }
        }


        public void Clear()
        {
            items.Clear();
            currentIndex = 0;
        }

        public void Next()
        {
            currentIndex++;
            if (currentIndex == items.Count)
                currentIndex = 0;
        }

        public void Previous()
        {
            currentIndex--;
            if (currentIndex == -1)
                currentIndex = items.Count - 1;
        }

        public SnapPoint Current()
        {
            return items.Keys[currentIndex].SnapPoint;
        }

        public static implicit operator Point2D(SnapPointCollection collection)
        {
            return collection.Current().Location;
        }
    }
}
