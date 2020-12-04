namespace InnerClassInheritance
{
    public abstract partial class ParentBase
    {
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
