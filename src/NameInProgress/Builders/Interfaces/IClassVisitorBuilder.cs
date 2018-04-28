﻿using NameInProgress.Conditions;
using NameInProgress.Entities;
using NameInProgress.Visitors;

namespace NameInProgress.Builders
{
    /// <summary>
    /// Interface for exposing the class visitor builder.
    /// </summary>
    public interface IClassVisitorBuilder
    {
        /// <summary>
        /// Builds the visitor and returns it.
        /// </summary>
        /// <returns>The visitor.</returns>
        IVisitor<ClassEntity> Build();

        /// <summary>
        /// Returns a builder for building a condition on generic parameter.
        /// </summary>
        /// <returns>The builder.</returns>
        IGenericParameterCondition<IClassVisitorBuilder> WithGenericParameter();

        /// <summary>
        /// Returns a builder for building a condition on accessibility.
        /// </summary>
        /// <returns>The builder.</returns>
        IAccessibilityCondition<IClassVisitorBuilder> WithAccessibility();

        /// <summary>
        /// Returns a builder for building a condition on name.
        /// </summary>
        /// <returns>The builder.</returns>
        INameCondition<IClassVisitorBuilder> WithName();

        /// <summary>
        /// Returns a builder for building a condition on namespace.
        /// </summary>
        /// <returns>The builder.</returns>
        INamespaceCondition<IClassVisitorBuilder> WithNamespace();
    }
}