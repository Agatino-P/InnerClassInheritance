using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InnerClassInheritance
{
    public abstract partial class ParentBase
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

        protected virtual void Do1()
        {
            _child.Do1();
        }

        protected abstract void Do2();
    }
}
