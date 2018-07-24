﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


using Microsoft.EntityFrameworkCore.Query.ResultOperators.Internal;

namespace Microsoft.EntityFrameworkCore.Query.Internal
{
    /// <summary>
    ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public class RelationalMethodInfoBasedNodeRegistryFactory : DefaultMethodInfoBasedNodeTypeRegistryFactory
    {
        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public RelationalMethodInfoBasedNodeRegistryFactory()
        {
            RegisterMethods(FromSqlExpressionNode.SupportedMethods, typeof(FromSqlExpressionNode));
        }
    }
}
