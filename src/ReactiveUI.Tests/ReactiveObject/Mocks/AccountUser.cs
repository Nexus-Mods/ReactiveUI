﻿// Copyright (c) 2023 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace ReactiveUI.Tests
{
    /// <summary>
    /// Account User.
    /// </summary>
    /// <seealso cref="ReactiveUI.ReactiveObject" />
    [DataContract]
    public class AccountUser : ReactiveObject
    {
        private string? _lastName;

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DataMember]
        public string? LastName
        {
            get => _lastName;
            set => this.RaiseAndSetIfChanged(ref _lastName, value);
        }
    }
}
