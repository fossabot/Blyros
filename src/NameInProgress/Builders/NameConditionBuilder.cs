﻿using System;
using NameInProgress.Conditions;

namespace NameInProgress.Builders
{
    /// <summary>
    /// Builder for creating a condition on names.
    /// </summary>
    /// <typeparam name="T">The type of the visitor that will use the condition.</typeparam>
    /// <typeparam name="TBuilder">The type of the object that will be returned at the end of the chain.</typeparam>
    internal class NameConditionBuilder<T, TBuilder> :
        StringConditionBuilder<T, TBuilder>,
        INameCondition<TBuilder>
        where T : TBuilder, INameChecker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameConditionBuilder{T1, T2}"/> class.
        /// </summary>
        /// <param name="visitor">The visitor that will use the condition.</param>
        public NameConditionBuilder(T visitor)
            : base(visitor)
        {
        }

        /// <inheritdoc/>
        public override void SetChecker(Func<string, bool> checker)
        {
            visitor.NameChecker = checker;
        }
    }
}