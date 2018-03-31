﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. 

using System;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Properties;

namespace Microsoft.OpenApi.Validations.Rules
{
    /// <summary>
    /// The validation rules for <see cref="OpenApiServer"/>.
    /// </summary>
    [OpenApiRule]
    public static class OpenApiServerRules
    {
        /// <summary>
        /// Validate the field is required.
        /// </summary>
        public static ValidationRule<OpenApiServer> FieldIsRequired =>
            new ValidationRule<OpenApiServer>(
                (context, server) =>
                {
                    context.Enter("url");
                    if (String.IsNullOrEmpty(server.Url))
                    {
                        OpenApiError error = new OpenApiError(ErrorReason.Required, context.PathString,
                            String.Format(SRResource.Validation_FieldIsRequired, "url", "server"));
                        context.AddError(error);
                    }
                    context.Exit();
                });

        // add more rules
    }
}
