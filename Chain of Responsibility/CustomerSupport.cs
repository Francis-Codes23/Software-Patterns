namespace COC2
{
   abstract internal class CustomerSupport
    {
        protected CustomerSupport NextSupport;
        public CustomerSupport SetNextSupport(CustomerSupport support)
        {
            NextSupport = support;
            return support;
        }
        public abstract void Handle(Request request);
    }
}
