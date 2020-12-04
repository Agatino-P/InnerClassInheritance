using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InnerClassInheritance
{
    public class ParentBase
    {
        protected  ChildBase _child;
        public int N1 { get; set; }

        public ParentBase()
        {
            _child = new ChildBase(this);
        }

        public virtual void Do()
        {
            _child.Do1();
        }
        protected class ChildBase
        {
            protected ParentBase _parent;
            public ChildBase(ParentBase parent)
            {
                _parent = parent;
            }
            public virtual void Do1()
            {
                _parent.N1++;
            }
        }
    }
}
