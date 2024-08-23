using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utilities
{
    internal class OperationResult<T>
    {
        public Boolean success { get; set; }
        public string message { get; set; }
        public T? data { get; set; }

       

        public OperationResult(Boolean success, string message, T? data)
        {
            this.success = success;
            this.message = message;
            this.data = data;
        }

        

      
    }
}
