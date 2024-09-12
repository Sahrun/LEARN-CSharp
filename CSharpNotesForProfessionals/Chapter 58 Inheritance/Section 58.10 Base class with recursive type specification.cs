using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_58_Inheritance
{
    /// <summary>
    /// Generic base class for a tree structure
    /// </summary>
    /// <typeparam name="T">The node type of the tree</typeparam>
    public abstract class Tree<T> where T : Tree<T>
    {
        /// <summary>
        /// Construct sets the parent node and adds this node to the parent's child nodes
        /// </summary>
        /// <param name="parent">The parent node or null if a root</param>
        protected Tree(T parent)
        {
            this.Parent = parent;
            this.Children = new List<T>();
            if (parent != null)
            {
                parent.Children.Add(this as T);
            }
        }

        public T Parent { get; private set; }
        public List<T> Children { get; private set; }
        public bool IsRoot { get { return Parent == null; } }
        public bool IsLeaf { get { return Children.Count == 0; } }
        /// <summary>
        /// Return the number of hops to the root object
        /// </summary>
        public int Level { get { return IsRoot ? 0 : Parent.Level + 1; } }
    }


    public class Part : Tree<Part>
    {
        public static readonly Part Empty = new Part(null) { Weight = 0 };

        public Part(Part parent) : base(parent) { }

        public Part Add(float weight)
        {
            return new Part(this) { Weight = weight };
        }
        public float Weight { get; set; }

        public float TotalWeight { get { return Weight + Children.Sum((part) => part.Weight); } }

    }


    public class RelativeCoordinate : Tree<RelativeCoordinate>
    {
        public static readonly RelativeCoordinate Start = new RelativeCoordinate(null, PointF.Empty)
        {

        };

        public RelativeCoordinate(RelativeCoordinate parent, PointF local_position)
            : base(parent)
        {
            this.LocalPosition = local_position;
        }

        public PointF LocalPosition { get; set; }

        public PointF GlobalPosition
        {
            get
            {
                if (IsRoot) return LocalPosition;

                var parent_pos = Parent.GlobalPosition;
                return new PointF(parent_pos.X + LocalPosition.X, parent_pos.Y + LocalPosition.Y);
            }

        }
        public float TotalDistance
        {
            get
            {
                float dist =
                    (float)Math.Sqrt(LocalPosition.X + LocalPosition.Y * LocalPosition.Y);
                return IsRoot ? dist : Parent.TotalDistance + dist;
            }
        }

        public RelativeCoordinate Add(PointF local_position)
        {
            return new RelativeCoordinate(this, local_position);
        }

        public RelativeCoordinate Add(float x, float y)
        {
            return Add(new PointF(x, y));
        }

    }

}
