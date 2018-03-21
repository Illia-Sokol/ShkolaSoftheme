//Copyright (C) Microsoft Corporation.  All rights reserved.

// AttributesTutorial.cs
// This example shows the use of class and method attributes.

using System;

// The IsTested class is a user-defined custom attribute class.
// It can be applied to any declaration including
//  - types (struct, class, enum, delegate)
//  - members (methods, fields, events, properties, indexers)
// It is used with no arguments.
public class IsTestedAttribute : Attribute
{
    public override string ToString()
    {
        return "Is Tested";
    }
}