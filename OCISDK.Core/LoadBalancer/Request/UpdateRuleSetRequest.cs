﻿using OCISDK.Core.LoadBalancer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCISDK.Core.LoadBalancer.Request
{
    /// <summary>
    /// UpdateRuleSet Request
    /// </summary>
    public class UpdateRuleSetRequest
    {
        /// <summary>
        /// The unique Oracle-assigned identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// <para>Required: no</para>
        /// </summary>
        public string OpcRequestId { get; set; }

        /// <summary>
        /// The OCID of the specified load balancer.
        /// <para>Required: yes</para>
        /// </summary>
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The name of the rule set to update.
        /// </summary>
        public string RuleSetName { get; set; }

        /// <summary>
        /// The request body must contain a single UpdateRuleSetDetails resource.
        /// </summary>
        public UpdateRuleSetDetails UpdateRuleSetDetails { get; set; }
    }
}
