using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole
{
    class ObjectId
    {
        private string Id;

        public ObjectId(string Id)
        {
            this.Id = Id;
        }

        public override string ToString()
        {
            return Id;
        }
    }
}