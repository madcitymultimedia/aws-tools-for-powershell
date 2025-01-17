/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.PaymentCryptography;
using Amazon.PaymentCryptography.Model;

namespace Amazon.PowerShell.Cmdlets.PAYCC
{
    /// <summary>
    /// Gets the import token and the wrapping key certificate to initiate a TR-34 key import
    /// into Amazon Web Services Payment Cryptography.
    /// 
    ///  
    /// <para>
    /// The wrapping key certificate wraps the key under import within the TR-34 key payload.
    /// The import token and wrapping key certificate must be in place and operational before
    /// calling <a>ImportKey</a>. The import token expires in 7 days. The same import token
    /// can be used to import multiple keys into your service account.
    /// </para><para><b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para><para><b>Related operations:</b></para><ul><li><para><a>GetParametersForExport</a></para></li><li><para><a>ImportKey</a></para></li></ul>
    /// </summary>
    [Cmdlet("Get", "PAYCCParametersForImport")]
    [OutputType("Amazon.PaymentCryptography.Model.GetParametersForImportResponse")]
    [AWSCmdlet("Calls the Payment Cryptography Control Plane GetParametersForImport API operation.", Operation = new[] {"GetParametersForImport"}, SelectReturnType = typeof(Amazon.PaymentCryptography.Model.GetParametersForImportResponse))]
    [AWSCmdletOutput("Amazon.PaymentCryptography.Model.GetParametersForImportResponse",
        "This cmdlet returns an Amazon.PaymentCryptography.Model.GetParametersForImportResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetPAYCCParametersForImportCmdlet : AmazonPaymentCryptographyClientCmdlet, IExecutor
    {
        
        protected override bool IsSensitiveResponse { get; set; } = true;
        
        #region Parameter KeyMaterialType
        /// <summary>
        /// <para>
        /// <para>The key block format type such as TR-34 or TR-31 to use during key material import.
        /// Import token is only required for TR-34 key import <code>TR34_KEY_BLOCK</code>. Import
        /// token is not required for TR-31 key import.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.PaymentCryptography.KeyMaterialType")]
        public Amazon.PaymentCryptography.KeyMaterialType KeyMaterialType { get; set; }
        #endregion
        
        #region Parameter WrappingKeyAlgorithm
        /// <summary>
        /// <para>
        /// <para>The wrapping key algorithm to generate a wrapping key certificate. This certificate
        /// wraps the key under import within the TR-34 key block cryptogram. <code>RSA_2048</code>
        /// is the only wrapping key algorithm allowed.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.PaymentCryptography.KeyAlgorithm")]
        public Amazon.PaymentCryptography.KeyAlgorithm WrappingKeyAlgorithm { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.PaymentCryptography.Model.GetParametersForImportResponse).
        /// Specifying the name of a property of type Amazon.PaymentCryptography.Model.GetParametersForImportResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the KeyMaterialType parameter.
        /// The -PassThru parameter is deprecated, use -Select '^KeyMaterialType' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^KeyMaterialType' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            this._AWSSignerType = "v4";
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.PaymentCryptography.Model.GetParametersForImportResponse, GetPAYCCParametersForImportCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.KeyMaterialType;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.KeyMaterialType = this.KeyMaterialType;
            #if MODULAR
            if (this.KeyMaterialType == null && ParameterWasBound(nameof(this.KeyMaterialType)))
            {
                WriteWarning("You are passing $null as a value for parameter KeyMaterialType which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.WrappingKeyAlgorithm = this.WrappingKeyAlgorithm;
            #if MODULAR
            if (this.WrappingKeyAlgorithm == null && ParameterWasBound(nameof(this.WrappingKeyAlgorithm)))
            {
                WriteWarning("You are passing $null as a value for parameter WrappingKeyAlgorithm which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.PaymentCryptography.Model.GetParametersForImportRequest();
            
            if (cmdletContext.KeyMaterialType != null)
            {
                request.KeyMaterialType = cmdletContext.KeyMaterialType;
            }
            if (cmdletContext.WrappingKeyAlgorithm != null)
            {
                request.WrappingKeyAlgorithm = cmdletContext.WrappingKeyAlgorithm;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.PaymentCryptography.Model.GetParametersForImportResponse CallAWSServiceOperation(IAmazonPaymentCryptography client, Amazon.PaymentCryptography.Model.GetParametersForImportRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Payment Cryptography Control Plane", "GetParametersForImport");
            try
            {
                #if DESKTOP
                return client.GetParametersForImport(request);
                #elif CORECLR
                return client.GetParametersForImportAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public Amazon.PaymentCryptography.KeyMaterialType KeyMaterialType { get; set; }
            public Amazon.PaymentCryptography.KeyAlgorithm WrappingKeyAlgorithm { get; set; }
            public System.Func<Amazon.PaymentCryptography.Model.GetParametersForImportResponse, GetPAYCCParametersForImportCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
