namespace InnerClassInheritance
{
    public class ParentDerived : ParentBase
    {
        protected new ChildDerived _child;
        public int N2 { get; set; }

        public ParentDerived()
        {
             _child= new ChildDerived(this);
        }
        public override void Do()
        {
            base.Do();
            _child.Do2();
        }

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
