using System;
using System.Net;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace HolmesRestorationManagementSystem.Business_Objects
{
    public class Notifications : IClient
    {
        private string m_sid, m_auth;

        public Notifications(string sid, string auth)
        {
            m_sid = sid;
            m_auth = auth;
        }

        public bool CanSendSms => true;
        public bool CanCall => true;
        public bool FromNumberRequired => true;
        public bool IsInitialized { get; set; }
        public void Init()
        {
            IsInitialized = true;
            TwilioClient.Init(m_sid,m_auth);
        }

        public async Task<IResponse> CallAsync(string from, string to, string msg)
        {
            var pnFrom = new PhoneNumber(from);
            var pnTo = new PhoneNumber(to);
            var body = WebUtility.UrlEncode(msg);

            var call = await CallResource.CreateAsync(
                pnTo,
                pnFrom,
                url: new Uri($"https://handler.twilio.com/twiml/EH200b2ba8066435fc07be850f7d1778fe?body={body}"));

            return new CallResponse(call);
        }
        public async Task<IResponse> SendSmsAsych(string from, string to, string msg)
        {
            var pnFrom = new PhoneNumber(from);
            var pnTo = new PhoneNumber(to);

            var text = await MessageResource.CreateAsync(
                pnTo,
                from: pnFrom,
                body: msg);

            return new TextResponse(text);
        }
        public override string ToString()
        {
            return "Holmes Management System";
        }

        public class CallResponse : IResponse
        {
            private string m_sid;
            public string Status { get; set; }

            public bool CanUpdate => true;

            public CallResponse(CallResource call)
            {
                SetCall(call);
            }
            private void SetCall(CallResource call)
            {
                m_sid = call.Sid;
                Status = call.Status.ToString();
            }
            public async Task UpdateAsync()
            {
                var call = await CallResource.FetchAsync(m_sid);
                SetCall(call);
            }
        }
        public class TextResponse : IResponse
        {
            private string m_sid;
            public string Status { get; set; }

            public bool CanUpdate => true;

            public TextResponse(MessageResource msg)
            {
                SetMessage(msg);
            }
            private void SetMessage(MessageResource msg)
            {
                m_sid = msg.Sid;
                Status = msg.Status.ToString();
            }
            public async Task UpdateAsync()
            {
                var msg = await MessageResource.FetchAsync(m_sid);
                SetMessage(msg);
            }
        }
    }
}
