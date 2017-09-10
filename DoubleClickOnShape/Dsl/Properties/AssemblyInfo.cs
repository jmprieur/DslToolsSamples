#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"Company")]
[assembly: AssemblyProduct(@"DoubleClickOnShape")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"Company.DoubleClickOnShape.DslPackage, PublicKey=002400000480000094000000060200000024000052534131000400000100010095CC18DB1082EF2F37DFB8EDE5684AFF199B94FF69842BE9D64D30E8D9E18F36DC08A6045332AB81921D30F4C7537A7FAE9A2F1B20B7A90E8241642A03C295824DE67FA84FF57391579E427355E25B0892B4044C453031B9B40F21713F5916D9C7F7A49B8EAF7D8D2AD153130E9EFA2EE4AD2679D1C174D200081A1FF12AD3F0")]