using System;

namespace CreateAndUseTypes.CreateAndImplementAClassHierarch
{
    class Example : IExample
    {
        public int this[string index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Value
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler ResultRetrieved;

        public string GetResult()
        {
            throw new NotImplementedException();
        }
    }
}
