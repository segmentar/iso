﻿using Core;

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        public static Expressionxportable ExpressionxportableRootVariation()
        {
            Expressionxportable expressionxportableResult = default;

            Expressionxportable expressionxportable;

            expressionxportable = new ExpressionxportableSimple(Expressionxportablename.EntityExpressionRoot, default(Object)).Result;

            expressionxportableResult = expressionxportable;

            return expressionxportableResult;
        }
    }
}
