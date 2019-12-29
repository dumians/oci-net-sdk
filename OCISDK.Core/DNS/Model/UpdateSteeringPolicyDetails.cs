﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.DNS.Model
{
    /// <summary>
    /// The body for updating a steering policy. New rules and answers provided in the request will replace the existing rules and answers in the policy.
    /// 
    /// Warning: Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// </summary>
    public class UpdateSteeringPolicyDetails
    {
        /// <summary>
        /// A user-friendly name for the steering policy. Does not have to be unique and can be changed. Avoid entering confidential information.
        /// <para>Required: no</para>
        /// <para>Min Length: 1, Max Length: 255</para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The Time To Live (TTL) for responses from the steering policy, in seconds. If not specified during creation, a value of 30 seconds will be used.
        /// <para>Required: no</para>, 
        /// <para>Minimum: 1, Maximum: 604800</para>
        /// </summary>
        public int? Ttl { get; set; }

        /// <summary>
        /// The OCID of the health check monitor providing health data about the answers of the steering policy. 
        /// A steering policy answer with rdata matching a monitored endpoint will use the health data of that endpoint. 
        /// A steering policy answer with rdata not matching any monitored endpoint will be assumed healthy.
        /// <para>Required: no</para>
        /// <para>Min Length: 1, Max Length: 255</para>
        /// </summary>
        public string HealthCheckMonitorId { get; set; }

        /// <summary>
        /// A set of predefined rules based on the desired purpose of the steering policy.
        /// Each template utilizes Traffic Management's rules in a different order to produce the desired results when answering DNS queries.
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// The set of all answers that can potentially issue from the steering policy.
        /// <para>Required: no</para>
        /// </summary>
        public List<SteeringPolicyAnswer> Answers { get; set; }

        /// <summary>
        /// The series of rules that will be processed in sequence to reduce the pool of answers to a response for any given request.
        /// 
        /// The first rule receives a shuffled list of all answers, and every other rule receives the list of answers emitted by the one preceding it.
        /// The last rule populates the response.
        /// <para>Required: no</para>
        /// <para>Max Items: 10</para>
        /// </summary>
        //TODO: Cannot parse JSON with multiple subtype structures.
        public object Rules { get; set; }

        /// <summary>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. 
        /// For more information, see Resource Tags.
        /// <para>Required: no</para>
        /// </summary>
        public IDictionary<string, string> FreeformTags { get; set; }

        /// <summary>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. 
        /// For more information, see Resource Tags.
        /// <para>Required: no</para>
        /// </summary>
        public IDictionary<string, IDictionary<string, string>> DefinedTags { get; set; }
    }
}
