﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports Microsoft.CodeAnalysis.Testing
Imports Microsoft.CodeAnalysis.Testing.Verifiers

<Obsolete(ObsoleteMessages.FrameworkPackages)>
Public Class SourceGeneratorVerifier(Of TSourceGenerator As New)
    Inherits VisualBasicSourceGeneratorVerifier(Of TSourceGenerator, MSTestVerifier)
End Class
