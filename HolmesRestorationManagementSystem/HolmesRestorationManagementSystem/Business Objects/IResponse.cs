using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public interface IResponse
    {
        /// <summary>
        /// The Response status
        /// </summary>
        string Status { get; set; }

        ///<summary>
        /// Indicates if the response can update
        ///</summary>
        bool CanUpdate { get; }

        ///<summary>
        /// Updates the response Asynchronously
        ///</summary>
        ///<returns> An awaitable task </returns>
        Task UpdateAsync();
    }
}
