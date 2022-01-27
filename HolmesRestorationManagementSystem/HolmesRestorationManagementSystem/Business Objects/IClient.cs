using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public interface IClient
    {
        /// <sumary>
        /// use <see cref="Init"/> to initialize client
        /// </sumary> determines in client is intialzied
        bool IsInitialized { get; set; }

        ///<summary>
        ///Indicates if can send sms
        ///</summary>
        bool CanSendSms { get;}

        /// <summary>
        /// Indicate if can call numbers
        /// </summary>
        bool CanCall { get; }
        bool FromNumberRequired { get; }
        /// <summary>
        /// Initalizes client and marks client as <see cref="IsInitialized"/>
        /// </summary>
        void Init();

        ///<summary> 
        /// calls the number Aschcronously
        ///</summary>
        /// <parm name="from"> The from number can be optional"> <see cref="FromNumberRequired"/></parm>
        /// <param name="to"> The number being called </param>
        /// <parm name="msg"> What is going to be said </parm>
        Task<IResponse> CallAsync(string from, string to, string msg);

        /// <summary>
        /// sents a text asynchronously
        /// </summary>
        /// <param name="from">The from number can be optional <see cref=">FromNumberRequired"/></param>
        /// <parm  name="to">The number being texted</parm>
        /// <parm name="msg">The message being sent</parm>
        Task<IResponse> SendSmsAsych(string from, string to, string msg);

        string ToString();

    }
}
