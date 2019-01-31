﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Ambrosia
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class ProxyGenerator : ProxyGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\nusing System;\r\nusing System.Threading.Tasks;\r\nusing System.Threading.Tasks.Data" +
                    "flow;\r\nusing Ambrosia;\r\nusing static Ambrosia.StreamCommunicator;\r\n\r\n");
            
            #line 13 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"

  var originalInterfaceName = this.interfaceType.Name;

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 17 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.interfaceType.Namespace));
            
            #line default
            #line hidden
            this.Write(@"
{
    /// <summary>
    /// This class is the proxy that runs in the client's process and communicates with the local Ambrosia runtime.
    /// It runs within the client's process, so it is generated in the language that the client is using.
    /// It is returned from ImmortalFactory.CreateClient when a client requests a container that supports the interface ");
            
            #line 22 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedClientInterfaceName));
            
            #line default
            #line hidden
            this.Write(".\r\n    /// </summary>\r\n    [System.Runtime.Serialization.DataContract]\r\n    publi" +
                    "c class ");
            
            #line 25 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(" : Immortal.InstanceProxy, ");
            
            #line 25 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedClientInterfaceName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n\r\n        public ");
            
            #line 28 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("(string remoteAmbrosiaRuntime, bool attachNeeded)\r\n            : base(remoteAmbro" +
                    "siaRuntime, attachNeeded)\r\n        {\r\n        }\r\n\r\n");
            
            #line 33 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"

    foreach (var M in this.methods) {
      var idNumber = M.idNumber;
      var parameterDeclarationString = Utilities.ParameterDeclarationString(M);
      var parameterString = String.Join(",", M.Parameters.Select(p => "p_" + p.Position.ToString()));
      var returnTypeName = M.ReturnType.Name;
	  var isImpulseHandler = M.isImpulseHandler;
      var voidMethod = M.voidMethod;


            
            #line default
            #line hidden
            
            #line 43 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 if (!isImpulseHandler) { 
            
            #line default
            #line hidden
            this.Write("        async ");
            
            #line 44 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("Task" + (voidMethod ? "" : "<" + returnTypeName + ">")));
            
            #line default
            #line hidden
            this.Write("\r\n        ");
            
            #line 45 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedClientInterfaceName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 45 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 45 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterDeclarationString));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n\t\t\t");
            
            #line 47 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((voidMethod ? "" : "return")));
            
            #line default
            #line hidden
            this.Write(" await ");
            
            #line 47 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 47 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterString));
            
            #line default
            #line hidden
            this.Write(");\r\n        }\r\n\r\n        async ");
            
            #line 50 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("Task" + (voidMethod ? "" : "<" + returnTypeName + ">")));
            
            #line default
            #line hidden
            this.Write("\r\n        ");
            
            #line 51 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 51 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterDeclarationString));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            SerializableTaskCompletionSource rpcTask;\r\n            " +
                    "// Make call, wait for reply\r\n            // Compute size of serialized argument" +
                    "s\r\n            var totalArgSize = 0;\r\n\r\n");
            
            #line 58 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"

        foreach (var p in M.Parameters) {
          var parIndex = p.Position;

            
            #line default
            #line hidden
            
            #line 62 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 if (!voidMethod) { 
            
            #line default
            #line hidden
            this.Write("\t\t\tvar p_");
            
            #line 63 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Parameters.Count()));
            
            #line default
            #line hidden
            this.Write(" = default(");
            
            #line 63 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.ReturnType.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 64 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\tint arg");
            
            #line 65 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("Size = 0;\r\n\t\t\tbyte[] arg");
            
            #line 66 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("Bytes = null;\r\n\r\n            // Argument ");
            
            #line 68 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("\r\n            ");
            
            #line 69 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.ComputeArgumentSize(p.ParameterType, p.Position)));
            
            #line default
            #line hidden
            this.Write("\r\n            totalArgSize += arg");
            
            #line 70 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("Size;\r\n");
            
            #line 71 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n            var wp = this.StartRPC<");
            
            #line 73 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(voidMethod ? "object" : returnTypeName));
            
            #line default
            #line hidden
            this.Write(">(methodIdentifier: ");
            
            #line 73 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(idNumber));
            
            #line default
            #line hidden
            this.Write(" /* method identifier for ");
            
            #line 73 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write(" */, lengthOfSerializedArguments: totalArgSize, taskToWaitFor: out rpcTask);\r\n\t\t\t" +
                    "var asyncContext = new AsyncContext { SequenceNumber = Immortal.CurrentSequenceN" +
                    "umber };\r\n\r\n            // Serialize arguments\r\n\r\n");
            
            #line 78 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"

        foreach (var p in M.Parameters) {
          var parIndex = p.Position;

            
            #line default
            #line hidden
            this.Write("\r\n            // Serialize arg");
            
            #line 83 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("\r\n            ");
            
            #line 84 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.SerializeValue(parIndex)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 85 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            int taskId;\r\n\t\t\tlock (Immortal.DispatchTaskIdQueueLock)\r\n            " +
                    "{\r\n                while (!Immortal.DispatchTaskIdQueue.Data.TryDequeue(out task" +
                    "Id)) { }\r\n            }\r\n\r\n            ReleaseBufferAndSend();\r\n\r\n\t\t\tImmortal.St" +
                    "artDispatchLoop();\r\n\r\n\t\t\tvar taskToWaitFor = Immortal.CallCache.Data[asyncContex" +
                    "t.SequenceNumber].GetAwaitableTaskWithAdditionalInfoAsync();\r\n            var cu" +
                    "rrentResult = await taskToWaitFor;\r\n\r\n\t\t\twhile (currentResult.AdditionalInfoType" +
                    " != ResultAdditionalInfoTypes.SetResult)\r\n            {\r\n                switch " +
                    "(currentResult.AdditionalInfoType)\r\n                {\r\n                    case " +
                    "ResultAdditionalInfoTypes.SaveContext:\r\n                        await Immortal.S" +
                    "aveTaskContextAsync();\r\n                        taskToWaitFor = Immortal.CallCac" +
                    "he.Data[asyncContext.SequenceNumber].GetAwaitableTaskWithAdditionalInfoAsync();\r" +
                    "\n                        break;\r\n                    case ResultAdditionalInfoTy" +
                    "pes.TakeCheckpoint:\r\n                        var sequenceNumber = await Immortal" +
                    ".TakeTaskCheckpointAsync();\r\n                        Immortal.StartDispatchLoop(" +
                    ");\r\n                        taskToWaitFor = Immortal.GetTaskToWaitForWithAdditio" +
                    "nalInfoAsync(sequenceNumber);\r\n                        break;\r\n                }" +
                    "\r\n\r\n                currentResult = await taskToWaitFor;\r\n            }\r\n\r\n     " +
                    "       lock (Immortal.DispatchTaskIdQueueLock)\r\n            {\r\n                I" +
                    "mmortal.DispatchTaskIdQueue.Data.Enqueue(taskId);\r\n            }\t\r\n");
            
            #line 121 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 if (voidMethod) { 
            
            #line default
            #line hidden
            this.Write("\t\t\treturn;\r\n");
            
            #line 123 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\t\treturn (");
            
            #line 124 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnTypeName));
            
            #line default
            #line hidden
            this.Write(") currentResult.Result;\r\n");
            
            #line 125 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 127 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n        void ");
            
            #line 129 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generatedClientInterfaceName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 129 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write("Fork(");
            
            #line 129 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterDeclarationString));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            SerializableTaskCompletionSource rpcTask;\r\n\r\n          " +
                    "  // Compute size of serialized arguments\r\n            var totalArgSize = 0;\r\n\r\n" +
                    "");
            
            #line 136 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"

        foreach (var p in M.Parameters) {
          var parIndex = p.Position;

            
            #line default
            #line hidden
            this.Write("            // Argument ");
            
            #line 140 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tint arg");
            
            #line 141 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("Size = 0;\r\n\t\t\tbyte[] arg");
            
            #line 142 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("Bytes = null;\r\n\r\n            ");
            
            #line 144 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.ComputeArgumentSize(p.ParameterType, p.Position)));
            
            #line default
            #line hidden
            this.Write("\r\n            totalArgSize += arg");
            
            #line 145 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("Size;\r\n");
            
            #line 146 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n            var wp = this.StartRPC<");
            
            #line 148 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(voidMethod ? "object" : returnTypeName));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 148 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(idNumber));
            
            #line default
            #line hidden
            this.Write(" /* method identifier for ");
            
            #line 148 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write(" */, totalArgSize, out rpcTask, ");
            
            #line 148 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(isImpulseHandler ? "RpcTypes.RpcType.Impulse" : "RpcTypes.RpcType.FireAndForget"));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n            // Serialize arguments\r\n\r\n");
            
            #line 152 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"

        foreach (var p in M.Parameters) {
          var parIndex = p.Position;

            
            #line default
            #line hidden
            this.Write("\r\n            // Serialize arg");
            
            #line 157 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parIndex));
            
            #line default
            #line hidden
            this.Write("\r\n            ");
            
            #line 158 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.SerializeValue(p.Position)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 159 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n            this.ReleaseBufferAndSend();\r\n            return;\r\n        }\r\n\r\n   " +
                    "     private ");
            
            #line 165 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(voidMethod ? "object" : returnTypeName));
            
            #line default
            #line hidden
            this.Write("\r\n        ");
            
            #line 166 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write("_ReturnValue(byte[] buffer, int cursor)\r\n        {\r\n");
            
            #line 168 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 if (voidMethod) { 
            
            #line default
            #line hidden
            this.Write("            // buffer will be an empty byte array since the method ");
            
            #line 169 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(M.Name));
            
            #line default
            #line hidden
            this.Write(" returns void\r\n            // so nothing to read, just getting called is the sign" +
                    "al to return to the client\r\n            return this;\r\n");
            
            #line 172 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            // deserialize return value\r\n            ");
            
            #line 174 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utilities.DeserializeValue(M.ReturnType, "returnValue")));
            
            #line default
            #line hidden
            this.Write("\r\n            return returnValue;\r\n");
            
            #line 176 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 178 "C:\Git\AMBROSIA\Clients\CSharp\AmbrosiaCS\ProxyGenerator.tt"

    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal class ProxyGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
