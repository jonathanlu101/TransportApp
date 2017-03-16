using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

namespace TransportApp.PTVApi.Client
{
    /// <summary>
    /// Extending ApiClient class 
    /// </summary>
    public partial class ApiClient
    {
        private String _devId;
        private String _apiKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with devId and apiKey.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        /// <param name="devId">devId</param>
        public ApiClient(String basePath, String devId, String apiKey) : this(basePath)
        {
            _devId = devId;
            _apiKey = apiKey;
        }

        /// <summary>
        /// Extending request proceessing.
        /// Adding devId & Signature to query params
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        partial void InterceptRequest(IRestRequest request)
        {
            request.AddQueryParameter("devid", _devId);
            var urlPath = RestClient.BuildUri(request).PathAndQuery;
            var signature = BuildSignature(urlPath, _apiKey);

            request.AddQueryParameter("signature", signature);
        }

        private string BuildSignature(string urlPath, string apiKey)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] keyBytes = encoding.GetBytes(_apiKey);
            byte[] urlBytes = encoding.GetBytes(urlPath);
            byte[] tokenBytes = new System.Security.Cryptography.HMACSHA1(keyBytes).ComputeHash(urlBytes);

            var stringBuilder = new StringBuilder();
            foreach (byte b in tokenBytes)
                stringBuilder.Append(b.ToString("X2"));

            return stringBuilder.ToString();
        }
    }
}
