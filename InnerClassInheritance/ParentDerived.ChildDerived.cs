namespace InnerClassInheritance
{
    public partial class ParentDerived
    {
        protected class ChildDerived : ChildBase
        {
            private new ParentDerived _parent;

            public ChildDerived(ParentDerived parent) : base(parent)
            {
                _parent = parent;
            }

            public override void Do1()
            {
                _parent.N1--;
            }
            public virtual void Do2()
            {
                _parent.N2--;
            }
        }
    }
}
