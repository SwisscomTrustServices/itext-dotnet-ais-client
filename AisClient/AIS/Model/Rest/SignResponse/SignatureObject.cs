﻿namespace AIS.Model.Rest.SignResponse
{
    public class SignatureObject
    {
        public Base64Signature Base64Signature { get; set; }

        public Timestamp Timestamp { get; set; }

        public Other Other { get; set; }
    }
}