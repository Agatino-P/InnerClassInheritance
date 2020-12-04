namespace InnerClassInheritance
{
    public partial class ParentDerived : ParentBase
    {
        protected new ChildDerived _child;
        public int N2 { get; set; }

        public ParentDerived()
        {
             _child= new ChildDerived(this);
        }
        public override void Do()
        {
            Do1();
            Do2();
        }

        protected override void Do1()
        {
            N1--;
        }
        protected override void Do2()
        {
            _child.Do2();
        }
    }
}
