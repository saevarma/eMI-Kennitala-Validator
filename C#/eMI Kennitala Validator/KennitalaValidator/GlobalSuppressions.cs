// <author>Stefán Örvar Sigmundsson</author>
// <copyright company="eMedia Intellect" file="GlobalSuppressions.cs">
//    Copyright © 2019 eMedia Intellect.
// </copyright>
// <licence>
//    This file is part of eMI Kennitala Validator.
//
//    eMI Kennitala Validator is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    eMI Kennitala Validator is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with eMI Kennitala Validator. If not, see http://www.gnu.org/licenses/.
// </licence>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Assembly signing is not required.")]
[assembly: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "The method is as complex as it must be.", Scope = "member", Target = "Emi.KennitalaValidator.Kennitala.#Validate(System.String)")]