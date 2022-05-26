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
using Amazon.EMRServerlessWebService;
using Amazon.EMRServerlessWebService.Model;

namespace Amazon.PowerShell.Cmdlets.EMRS
{
    /// <summary>
    /// Starts a job run.
    /// </summary>
    [Cmdlet("Start", "EMRSJobRun", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.EMRServerlessWebService.Model.StartJobRunResponse")]
    [AWSCmdlet("Calls the EMR Serverless Web Service StartJobRun API operation.", Operation = new[] {"StartJobRun"}, SelectReturnType = typeof(Amazon.EMRServerlessWebService.Model.StartJobRunResponse))]
    [AWSCmdletOutput("Amazon.EMRServerlessWebService.Model.StartJobRunResponse",
        "This cmdlet returns an Amazon.EMRServerlessWebService.Model.StartJobRunResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class StartEMRSJobRunCmdlet : AmazonEMRServerlessWebServiceClientCmdlet, IExecutor
    {
        
        #region Parameter ConfigurationOverrides_ApplicationConfiguration
        /// <summary>
        /// <para>
        /// <para>The override configurations for the application.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.EMRServerlessWebService.Model.Configuration[] ConfigurationOverrides_ApplicationConfiguration { get; set; }
        #endregion
        
        #region Parameter ApplicationId
        /// <summary>
        /// <para>
        /// <para>The ID of the application on which to run the job.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String ApplicationId { get; set; }
        #endregion
        
        #region Parameter ManagedPersistenceMonitoringConfiguration_Enabled
        /// <summary>
        /// <para>
        /// <para>Enables managed logging and defaults to true. If set to false, managed logging will
        /// be turned off.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ConfigurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_Enabled")]
        public System.Boolean? ManagedPersistenceMonitoringConfiguration_Enabled { get; set; }
        #endregion
        
        #region Parameter ManagedPersistenceMonitoringConfiguration_EncryptionKeyArn
        /// <summary>
        /// <para>
        /// <para>The KMS key ARN to encrypt the logs stored in managed log persistence.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ConfigurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_EncryptionKeyArn")]
        public System.String ManagedPersistenceMonitoringConfiguration_EncryptionKeyArn { get; set; }
        #endregion
        
        #region Parameter S3MonitoringConfiguration_EncryptionKeyArn
        /// <summary>
        /// <para>
        /// <para>The KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ConfigurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_EncryptionKeyArn")]
        public System.String S3MonitoringConfiguration_EncryptionKeyArn { get; set; }
        #endregion
        
        #region Parameter SparkSubmit_EntryPoint
        /// <summary>
        /// <para>
        /// <para>The entry point for the Spark submit job run.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("JobDriver_SparkSubmit_EntryPoint")]
        public System.String SparkSubmit_EntryPoint { get; set; }
        #endregion
        
        #region Parameter SparkSubmit_EntryPointArgument
        /// <summary>
        /// <para>
        /// <para>The arguments for the Spark submit job run.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("JobDriver_SparkSubmit_EntryPointArguments")]
        public System.String[] SparkSubmit_EntryPointArgument { get; set; }
        #endregion
        
        #region Parameter ExecutionRoleArn
        /// <summary>
        /// <para>
        /// <para>The execution role ARN for the job run.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String ExecutionRoleArn { get; set; }
        #endregion
        
        #region Parameter ExecutionTimeoutMinute
        /// <summary>
        /// <para>
        /// <para>The maximum duration for the job run to run. If the job run runs beyond this duration,
        /// it will be automatically cancelled.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ExecutionTimeoutMinutes")]
        public System.Int64? ExecutionTimeoutMinute { get; set; }
        #endregion
        
        #region Parameter Hive_InitQueryFile
        /// <summary>
        /// <para>
        /// <para>The query file for the Hive job run.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("JobDriver_Hive_InitQueryFile")]
        public System.String Hive_InitQueryFile { get; set; }
        #endregion
        
        #region Parameter S3MonitoringConfiguration_LogUri
        /// <summary>
        /// <para>
        /// <para>The Amazon S3 destination URI for log publishing.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("ConfigurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_LogUri")]
        public System.String S3MonitoringConfiguration_LogUri { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The optional job run name. This doesn't have to be unique.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter Hive_Parameter
        /// <summary>
        /// <para>
        /// <para>The parameters for the Hive job run.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("JobDriver_Hive_Parameters")]
        public System.String Hive_Parameter { get; set; }
        #endregion
        
        #region Parameter Hive_Query
        /// <summary>
        /// <para>
        /// <para>The query for the Hive job run.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("JobDriver_Hive_Query")]
        public System.String Hive_Query { get; set; }
        #endregion
        
        #region Parameter SparkSubmit_SparkSubmitParameter
        /// <summary>
        /// <para>
        /// <para>The parameters for the Spark submit job run.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("JobDriver_SparkSubmit_SparkSubmitParameters")]
        public System.String SparkSubmit_SparkSubmitParameter { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>The tags assigned to the job run.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public System.Collections.Hashtable Tag { get; set; }
        #endregion
        
        #region Parameter ClientToken
        /// <summary>
        /// <para>
        /// <para>The client idempotency token of the job run to start. Its value must be unique for
        /// each request.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.EMRServerlessWebService.Model.StartJobRunResponse).
        /// Specifying the name of a property of type Amazon.EMRServerlessWebService.Model.StartJobRunResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the ApplicationId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^ApplicationId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^ApplicationId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.ApplicationId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Start-EMRSJobRun (StartJobRun)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.EMRServerlessWebService.Model.StartJobRunResponse, StartEMRSJobRunCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.ApplicationId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ApplicationId = this.ApplicationId;
            #if MODULAR
            if (this.ApplicationId == null && ParameterWasBound(nameof(this.ApplicationId)))
            {
                WriteWarning("You are passing $null as a value for parameter ApplicationId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ClientToken = this.ClientToken;
            if (this.ConfigurationOverrides_ApplicationConfiguration != null)
            {
                context.ConfigurationOverrides_ApplicationConfiguration = new List<Amazon.EMRServerlessWebService.Model.Configuration>(this.ConfigurationOverrides_ApplicationConfiguration);
            }
            context.ManagedPersistenceMonitoringConfiguration_Enabled = this.ManagedPersistenceMonitoringConfiguration_Enabled;
            context.ManagedPersistenceMonitoringConfiguration_EncryptionKeyArn = this.ManagedPersistenceMonitoringConfiguration_EncryptionKeyArn;
            context.S3MonitoringConfiguration_EncryptionKeyArn = this.S3MonitoringConfiguration_EncryptionKeyArn;
            context.S3MonitoringConfiguration_LogUri = this.S3MonitoringConfiguration_LogUri;
            context.ExecutionRoleArn = this.ExecutionRoleArn;
            #if MODULAR
            if (this.ExecutionRoleArn == null && ParameterWasBound(nameof(this.ExecutionRoleArn)))
            {
                WriteWarning("You are passing $null as a value for parameter ExecutionRoleArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ExecutionTimeoutMinute = this.ExecutionTimeoutMinute;
            context.Hive_InitQueryFile = this.Hive_InitQueryFile;
            context.Hive_Parameter = this.Hive_Parameter;
            context.Hive_Query = this.Hive_Query;
            context.SparkSubmit_EntryPoint = this.SparkSubmit_EntryPoint;
            if (this.SparkSubmit_EntryPointArgument != null)
            {
                context.SparkSubmit_EntryPointArgument = new List<System.String>(this.SparkSubmit_EntryPointArgument);
            }
            context.SparkSubmit_SparkSubmitParameter = this.SparkSubmit_SparkSubmitParameter;
            context.Name = this.Name;
            if (this.Tag != null)
            {
                context.Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Tag.Keys)
                {
                    context.Tag.Add((String)hashKey, (String)(this.Tag[hashKey]));
                }
            }
            
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
            var request = new Amazon.EMRServerlessWebService.Model.StartJobRunRequest();
            
            if (cmdletContext.ApplicationId != null)
            {
                request.ApplicationId = cmdletContext.ApplicationId;
            }
            if (cmdletContext.ClientToken != null)
            {
                request.ClientToken = cmdletContext.ClientToken;
            }
            
             // populate ConfigurationOverrides
            var requestConfigurationOverridesIsNull = true;
            request.ConfigurationOverrides = new Amazon.EMRServerlessWebService.Model.ConfigurationOverrides();
            List<Amazon.EMRServerlessWebService.Model.Configuration> requestConfigurationOverrides_configurationOverrides_ApplicationConfiguration = null;
            if (cmdletContext.ConfigurationOverrides_ApplicationConfiguration != null)
            {
                requestConfigurationOverrides_configurationOverrides_ApplicationConfiguration = cmdletContext.ConfigurationOverrides_ApplicationConfiguration;
            }
            if (requestConfigurationOverrides_configurationOverrides_ApplicationConfiguration != null)
            {
                request.ConfigurationOverrides.ApplicationConfiguration = requestConfigurationOverrides_configurationOverrides_ApplicationConfiguration;
                requestConfigurationOverridesIsNull = false;
            }
            Amazon.EMRServerlessWebService.Model.MonitoringConfiguration requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration = null;
            
             // populate MonitoringConfiguration
            var requestConfigurationOverrides_configurationOverrides_MonitoringConfigurationIsNull = true;
            requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration = new Amazon.EMRServerlessWebService.Model.MonitoringConfiguration();
            Amazon.EMRServerlessWebService.Model.ManagedPersistenceMonitoringConfiguration requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration = null;
            
             // populate ManagedPersistenceMonitoringConfiguration
            var requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfigurationIsNull = true;
            requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration = new Amazon.EMRServerlessWebService.Model.ManagedPersistenceMonitoringConfiguration();
            System.Boolean? requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_managedPersistenceMonitoringConfiguration_Enabled = null;
            if (cmdletContext.ManagedPersistenceMonitoringConfiguration_Enabled != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_managedPersistenceMonitoringConfiguration_Enabled = cmdletContext.ManagedPersistenceMonitoringConfiguration_Enabled.Value;
            }
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_managedPersistenceMonitoringConfiguration_Enabled != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration.Enabled = requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_managedPersistenceMonitoringConfiguration_Enabled.Value;
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfigurationIsNull = false;
            }
            System.String requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_managedPersistenceMonitoringConfiguration_EncryptionKeyArn = null;
            if (cmdletContext.ManagedPersistenceMonitoringConfiguration_EncryptionKeyArn != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_managedPersistenceMonitoringConfiguration_EncryptionKeyArn = cmdletContext.ManagedPersistenceMonitoringConfiguration_EncryptionKeyArn;
            }
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_managedPersistenceMonitoringConfiguration_EncryptionKeyArn != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration.EncryptionKeyArn = requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration_managedPersistenceMonitoringConfiguration_EncryptionKeyArn;
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfigurationIsNull = false;
            }
             // determine if requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration should be set to null
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfigurationIsNull)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration = null;
            }
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration.ManagedPersistenceMonitoringConfiguration = requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_ManagedPersistenceMonitoringConfiguration;
                requestConfigurationOverrides_configurationOverrides_MonitoringConfigurationIsNull = false;
            }
            Amazon.EMRServerlessWebService.Model.S3MonitoringConfiguration requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration = null;
            
             // populate S3MonitoringConfiguration
            var requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfigurationIsNull = true;
            requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration = new Amazon.EMRServerlessWebService.Model.S3MonitoringConfiguration();
            System.String requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_s3MonitoringConfiguration_EncryptionKeyArn = null;
            if (cmdletContext.S3MonitoringConfiguration_EncryptionKeyArn != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_s3MonitoringConfiguration_EncryptionKeyArn = cmdletContext.S3MonitoringConfiguration_EncryptionKeyArn;
            }
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_s3MonitoringConfiguration_EncryptionKeyArn != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration.EncryptionKeyArn = requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_s3MonitoringConfiguration_EncryptionKeyArn;
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfigurationIsNull = false;
            }
            System.String requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_s3MonitoringConfiguration_LogUri = null;
            if (cmdletContext.S3MonitoringConfiguration_LogUri != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_s3MonitoringConfiguration_LogUri = cmdletContext.S3MonitoringConfiguration_LogUri;
            }
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_s3MonitoringConfiguration_LogUri != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration.LogUri = requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration_s3MonitoringConfiguration_LogUri;
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfigurationIsNull = false;
            }
             // determine if requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration should be set to null
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfigurationIsNull)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration = null;
            }
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration != null)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration.S3MonitoringConfiguration = requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration_configurationOverrides_MonitoringConfiguration_S3MonitoringConfiguration;
                requestConfigurationOverrides_configurationOverrides_MonitoringConfigurationIsNull = false;
            }
             // determine if requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration should be set to null
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfigurationIsNull)
            {
                requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration = null;
            }
            if (requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration != null)
            {
                request.ConfigurationOverrides.MonitoringConfiguration = requestConfigurationOverrides_configurationOverrides_MonitoringConfiguration;
                requestConfigurationOverridesIsNull = false;
            }
             // determine if request.ConfigurationOverrides should be set to null
            if (requestConfigurationOverridesIsNull)
            {
                request.ConfigurationOverrides = null;
            }
            if (cmdletContext.ExecutionRoleArn != null)
            {
                request.ExecutionRoleArn = cmdletContext.ExecutionRoleArn;
            }
            if (cmdletContext.ExecutionTimeoutMinute != null)
            {
                request.ExecutionTimeoutMinutes = cmdletContext.ExecutionTimeoutMinute.Value;
            }
            
             // populate JobDriver
            var requestJobDriverIsNull = true;
            request.JobDriver = new Amazon.EMRServerlessWebService.Model.JobDriver();
            Amazon.EMRServerlessWebService.Model.Hive requestJobDriver_jobDriver_Hive = null;
            
             // populate Hive
            var requestJobDriver_jobDriver_HiveIsNull = true;
            requestJobDriver_jobDriver_Hive = new Amazon.EMRServerlessWebService.Model.Hive();
            System.String requestJobDriver_jobDriver_Hive_hive_InitQueryFile = null;
            if (cmdletContext.Hive_InitQueryFile != null)
            {
                requestJobDriver_jobDriver_Hive_hive_InitQueryFile = cmdletContext.Hive_InitQueryFile;
            }
            if (requestJobDriver_jobDriver_Hive_hive_InitQueryFile != null)
            {
                requestJobDriver_jobDriver_Hive.InitQueryFile = requestJobDriver_jobDriver_Hive_hive_InitQueryFile;
                requestJobDriver_jobDriver_HiveIsNull = false;
            }
            System.String requestJobDriver_jobDriver_Hive_hive_Parameter = null;
            if (cmdletContext.Hive_Parameter != null)
            {
                requestJobDriver_jobDriver_Hive_hive_Parameter = cmdletContext.Hive_Parameter;
            }
            if (requestJobDriver_jobDriver_Hive_hive_Parameter != null)
            {
                requestJobDriver_jobDriver_Hive.Parameters = requestJobDriver_jobDriver_Hive_hive_Parameter;
                requestJobDriver_jobDriver_HiveIsNull = false;
            }
            System.String requestJobDriver_jobDriver_Hive_hive_Query = null;
            if (cmdletContext.Hive_Query != null)
            {
                requestJobDriver_jobDriver_Hive_hive_Query = cmdletContext.Hive_Query;
            }
            if (requestJobDriver_jobDriver_Hive_hive_Query != null)
            {
                requestJobDriver_jobDriver_Hive.Query = requestJobDriver_jobDriver_Hive_hive_Query;
                requestJobDriver_jobDriver_HiveIsNull = false;
            }
             // determine if requestJobDriver_jobDriver_Hive should be set to null
            if (requestJobDriver_jobDriver_HiveIsNull)
            {
                requestJobDriver_jobDriver_Hive = null;
            }
            if (requestJobDriver_jobDriver_Hive != null)
            {
                request.JobDriver.Hive = requestJobDriver_jobDriver_Hive;
                requestJobDriverIsNull = false;
            }
            Amazon.EMRServerlessWebService.Model.SparkSubmit requestJobDriver_jobDriver_SparkSubmit = null;
            
             // populate SparkSubmit
            var requestJobDriver_jobDriver_SparkSubmitIsNull = true;
            requestJobDriver_jobDriver_SparkSubmit = new Amazon.EMRServerlessWebService.Model.SparkSubmit();
            System.String requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_EntryPoint = null;
            if (cmdletContext.SparkSubmit_EntryPoint != null)
            {
                requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_EntryPoint = cmdletContext.SparkSubmit_EntryPoint;
            }
            if (requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_EntryPoint != null)
            {
                requestJobDriver_jobDriver_SparkSubmit.EntryPoint = requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_EntryPoint;
                requestJobDriver_jobDriver_SparkSubmitIsNull = false;
            }
            List<System.String> requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_EntryPointArgument = null;
            if (cmdletContext.SparkSubmit_EntryPointArgument != null)
            {
                requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_EntryPointArgument = cmdletContext.SparkSubmit_EntryPointArgument;
            }
            if (requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_EntryPointArgument != null)
            {
                requestJobDriver_jobDriver_SparkSubmit.EntryPointArguments = requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_EntryPointArgument;
                requestJobDriver_jobDriver_SparkSubmitIsNull = false;
            }
            System.String requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_SparkSubmitParameter = null;
            if (cmdletContext.SparkSubmit_SparkSubmitParameter != null)
            {
                requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_SparkSubmitParameter = cmdletContext.SparkSubmit_SparkSubmitParameter;
            }
            if (requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_SparkSubmitParameter != null)
            {
                requestJobDriver_jobDriver_SparkSubmit.SparkSubmitParameters = requestJobDriver_jobDriver_SparkSubmit_sparkSubmit_SparkSubmitParameter;
                requestJobDriver_jobDriver_SparkSubmitIsNull = false;
            }
             // determine if requestJobDriver_jobDriver_SparkSubmit should be set to null
            if (requestJobDriver_jobDriver_SparkSubmitIsNull)
            {
                requestJobDriver_jobDriver_SparkSubmit = null;
            }
            if (requestJobDriver_jobDriver_SparkSubmit != null)
            {
                request.JobDriver.SparkSubmit = requestJobDriver_jobDriver_SparkSubmit;
                requestJobDriverIsNull = false;
            }
             // determine if request.JobDriver should be set to null
            if (requestJobDriverIsNull)
            {
                request.JobDriver = null;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.EMRServerlessWebService.Model.StartJobRunResponse CallAWSServiceOperation(IAmazonEMRServerlessWebService client, Amazon.EMRServerlessWebService.Model.StartJobRunRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "EMR Serverless Web Service", "StartJobRun");
            try
            {
                #if DESKTOP
                return client.StartJobRun(request);
                #elif CORECLR
                return client.StartJobRunAsync(request).GetAwaiter().GetResult();
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
            public System.String ApplicationId { get; set; }
            public System.String ClientToken { get; set; }
            public List<Amazon.EMRServerlessWebService.Model.Configuration> ConfigurationOverrides_ApplicationConfiguration { get; set; }
            public System.Boolean? ManagedPersistenceMonitoringConfiguration_Enabled { get; set; }
            public System.String ManagedPersistenceMonitoringConfiguration_EncryptionKeyArn { get; set; }
            public System.String S3MonitoringConfiguration_EncryptionKeyArn { get; set; }
            public System.String S3MonitoringConfiguration_LogUri { get; set; }
            public System.String ExecutionRoleArn { get; set; }
            public System.Int64? ExecutionTimeoutMinute { get; set; }
            public System.String Hive_InitQueryFile { get; set; }
            public System.String Hive_Parameter { get; set; }
            public System.String Hive_Query { get; set; }
            public System.String SparkSubmit_EntryPoint { get; set; }
            public List<System.String> SparkSubmit_EntryPointArgument { get; set; }
            public System.String SparkSubmit_SparkSubmitParameter { get; set; }
            public System.String Name { get; set; }
            public Dictionary<System.String, System.String> Tag { get; set; }
            public System.Func<Amazon.EMRServerlessWebService.Model.StartJobRunResponse, StartEMRSJobRunCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}