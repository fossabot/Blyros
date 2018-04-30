﻿using System;
using Microsoft.CodeAnalysis;
using NameInProgress.Conditions;
using NameInProgress.Entities;
using NameInProgress.Visitors;

namespace NameInProgress.Builders
{
    /// <summary>
    /// Builder for a the class visitor.
    /// </summary>
    internal class ClassVisitorBuilder : IClassVisitorBuilder
    {
        /// <summary>
        /// Gets or sets the function used to check name.
        /// </summary>
        public Func<string, bool> NameChecker { get; set; }

        /// <summary>
        /// Gets or sets the function used to check namespace.
        /// </summary>
        public Func<string, bool> NamespaceChecker { get; set; }

        /// <summary>
        /// Gets or sets the function used to check the accessibility.
        /// </summary>
        public Func<Accessibility, bool> AccessibilityChecker { get; set; }

        /// <summary>
        /// Gets or sets the function used to check generic parameters.
        /// </summary>
        public Func<ITypeParameterSymbol, bool> GenericParameterChecker { get; set; }

        /// <inheritdoc/>
        public IStringCondition<IClassVisitorBuilder> WithName()
        {
            return new StringConditionBuilder<IClassVisitorBuilder>(this, checker => NameChecker = checker);
        }

        /// <inheritdoc/>
        public IAccessibilityCondition<IClassVisitorBuilder> WithAccessibility()
        {
            return new AccessibilityConditionBuilder<IClassVisitorBuilder>(this, checker => AccessibilityChecker = checker);
        }

        /// <inheritdoc/>
        public IGenericParameterCondition<IClassVisitorBuilder> WithGenericParameter()
        {
            return new GenericParameterConditionBuilder<IClassVisitorBuilder>(this, checker => GenericParameterChecker = checker);
        }

        /// <inheritdoc/>
        public IStringCondition<IClassVisitorBuilder> WithNamespace()
        {
            return new StringConditionBuilder<IClassVisitorBuilder>(this, checker => NamespaceChecker = checker);
        }

        /// <inheritdoc/>
        public IVisitor<ClassEntity> Build() => new ClassVisitor(NameChecker, AccessibilityChecker, GenericParameterChecker, NamespaceChecker);
    }
}