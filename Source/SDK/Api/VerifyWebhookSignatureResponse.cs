//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// The verify webhook signature response.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class VerifyWebhookSignatureResponse : PayPalSerializableObject
    {
        /// <summary>
        /// The status of the signature verification. Value is `SUCCESS` or `FAILURE`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "verification_status")]
        public string verification_status { get; set; }
    }
}