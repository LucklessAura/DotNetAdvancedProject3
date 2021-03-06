﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceImageManager
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="File", Namespace="http://schemas.datacontract.org/2004/07/Project1", IsReference=true)]
    public partial class File : object
    {
        
        private System.Collections.Generic.List<ServiceReferenceImageManager.AditionalFilePropriety> AditionalFileProprietiesField;
        
        private string DateCreatedField;
        
        private bool DeletedField;
        
        private int FileIdField;
        
        private string FileNameField;
        
        private string FilePathField;
        
        private string OcasionField;
        
        private string PeopleField;
        
        private string PlaceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceImageManager.AditionalFilePropriety> AditionalFileProprieties
        {
            get
            {
                return this.AditionalFileProprietiesField;
            }
            set
            {
                this.AditionalFileProprietiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateCreated
        {
            get
            {
                return this.DateCreatedField;
            }
            set
            {
                this.DateCreatedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FileId
        {
            get
            {
                return this.FileIdField;
            }
            set
            {
                this.FileIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName
        {
            get
            {
                return this.FileNameField;
            }
            set
            {
                this.FileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FilePath
        {
            get
            {
                return this.FilePathField;
            }
            set
            {
                this.FilePathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ocasion
        {
            get
            {
                return this.OcasionField;
            }
            set
            {
                this.OcasionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Place
        {
            get
            {
                return this.PlaceField;
            }
            set
            {
                this.PlaceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AditionalFilePropriety", Namespace="http://schemas.datacontract.org/2004/07/Project1", IsReference=true)]
    public partial class AditionalFilePropriety : object
    {
        
        private int AditionalFileProprietyIdField;
        
        private ServiceReferenceImageManager.File FileField;
        
        private int ForeignFileIdField;
        
        private string ProprietyNameField;
        
        private string ProprietyValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AditionalFileProprietyId
        {
            get
            {
                return this.AditionalFileProprietyIdField;
            }
            set
            {
                this.AditionalFileProprietyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceImageManager.File File
        {
            get
            {
                return this.FileField;
            }
            set
            {
                this.FileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ForeignFileId
        {
            get
            {
                return this.ForeignFileIdField;
            }
            set
            {
                this.ForeignFileIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProprietyName
        {
            get
            {
                return this.ProprietyNameField;
            }
            set
            {
                this.ProprietyNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProprietyValue
        {
            get
            {
                return this.ProprietyValueField;
            }
            set
            {
                this.ProprietyValueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceImageManager.interfaceClasses")]
    public interface interfaceClasses
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/AddNewFile", ReplyAction="http://tempuri.org/interfaceClasses/AddNewFileResponse")]
        System.Threading.Tasks.Task AddNewFileAsync(System.Collections.Generic.Dictionary<string, string> newFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/AddNewPropriety", ReplyAction="http://tempuri.org/interfaceClasses/AddNewProprietyResponse")]
        System.Threading.Tasks.Task AddNewProprietyAsync(ServiceReferenceImageManager.File file, string proprietyName, string proprietyValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/CopyFilesToPath", ReplyAction="http://tempuri.org/interfaceClasses/CopyFilesToPathResponse")]
        System.Threading.Tasks.Task<bool> CopyFilesToPathAsync(string path, System.Collections.Generic.List<int> filesIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/DefinitiveDelete", ReplyAction="http://tempuri.org/interfaceClasses/DefinitiveDeleteResponse")]
        System.Threading.Tasks.Task<bool> DefinitiveDeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/DeleteFile", ReplyAction="http://tempuri.org/interfaceClasses/DeleteFileResponse")]
        System.Threading.Tasks.Task<bool> DeleteFileAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/GetFileProprieties", ReplyAction="http://tempuri.org/interfaceClasses/GetFileProprietiesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetFileProprietiesAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/ModifyFile", ReplyAction="http://tempuri.org/interfaceClasses/ModifyFileResponse")]
        System.Threading.Tasks.Task ModifyFileAsync(int id, System.Collections.Generic.Dictionary<string, string> newProprieties);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/MoveFilesToPath", ReplyAction="http://tempuri.org/interfaceClasses/MoveFilesToPathResponse")]
        System.Threading.Tasks.Task<bool> MoveFilesToPathAsync(string path, System.Collections.Generic.List<int> filesId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/Restore", ReplyAction="http://tempuri.org/interfaceClasses/RestoreResponse")]
        System.Threading.Tasks.Task RestoreAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/SearchFiles", ReplyAction="http://tempuri.org/interfaceClasses/SearchFilesResponse")]
        System.Threading.Tasks.Task<System.ValueTuple<System.Collections.Generic.List<ServiceReferenceImageManager.File>, System.Collections.Generic.List<ServiceReferenceImageManager.File>>> SearchFilesAsync(System.Collections.Generic.Dictionary<string, string> proprieties);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/SendEmail", ReplyAction="http://tempuri.org/interfaceClasses/SendEmailResponse")]
        System.Threading.Tasks.Task SendEmailAsync(string to, string from, string subject, string body, System.Collections.Generic.List<int> filesIds, string email, string emailPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/GetImageBytes", ReplyAction="http://tempuri.org/interfaceClasses/GetImageBytesResponse")]
        System.Threading.Tasks.Task<byte[]> GetImageBytesAsync(int fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/interfaceClasses/GetDistinctProprietyNames", ReplyAction="http://tempuri.org/interfaceClasses/GetDistinctProprietyNamesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetDistinctProprietyNamesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface interfaceClassesChannel : ServiceReferenceImageManager.interfaceClasses, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class interfaceClassesClient : System.ServiceModel.ClientBase<ServiceReferenceImageManager.interfaceClasses>, ServiceReferenceImageManager.interfaceClasses
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public interfaceClassesClient() : 
                base(interfaceClassesClient.GetDefaultBinding(), interfaceClassesClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_interfaceClasses.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public interfaceClassesClient(EndpointConfiguration endpointConfiguration) : 
                base(interfaceClassesClient.GetBindingForEndpoint(endpointConfiguration), interfaceClassesClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public interfaceClassesClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(interfaceClassesClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public interfaceClassesClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(interfaceClassesClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public interfaceClassesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task AddNewFileAsync(System.Collections.Generic.Dictionary<string, string> newFile)
        {
            return base.Channel.AddNewFileAsync(newFile);
        }
        
        public System.Threading.Tasks.Task AddNewProprietyAsync(ServiceReferenceImageManager.File file, string proprietyName, string proprietyValue)
        {
            return base.Channel.AddNewProprietyAsync(file, proprietyName, proprietyValue);
        }
        
        public System.Threading.Tasks.Task<bool> CopyFilesToPathAsync(string path, System.Collections.Generic.List<int> filesIds)
        {
            return base.Channel.CopyFilesToPathAsync(path, filesIds);
        }
        
        public System.Threading.Tasks.Task<bool> DefinitiveDeleteAsync(int id)
        {
            return base.Channel.DefinitiveDeleteAsync(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteFileAsync(int id)
        {
            return base.Channel.DeleteFileAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, string>> GetFileProprietiesAsync(int id)
        {
            return base.Channel.GetFileProprietiesAsync(id);
        }
        
        public System.Threading.Tasks.Task ModifyFileAsync(int id, System.Collections.Generic.Dictionary<string, string> newProprieties)
        {
            return base.Channel.ModifyFileAsync(id, newProprieties);
        }
        
        public System.Threading.Tasks.Task<bool> MoveFilesToPathAsync(string path, System.Collections.Generic.List<int> filesId)
        {
            return base.Channel.MoveFilesToPathAsync(path, filesId);
        }
        
        public System.Threading.Tasks.Task RestoreAsync(int id)
        {
            return base.Channel.RestoreAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.ValueTuple<System.Collections.Generic.List<ServiceReferenceImageManager.File>, System.Collections.Generic.List<ServiceReferenceImageManager.File>>> SearchFilesAsync(System.Collections.Generic.Dictionary<string, string> proprieties)
        {
            return base.Channel.SearchFilesAsync(proprieties);
        }
        
        public System.Threading.Tasks.Task SendEmailAsync(string to, string from, string subject, string body, System.Collections.Generic.List<int> filesIds, string email, string emailPassword)
        {
            return base.Channel.SendEmailAsync(to, from, subject, body, filesIds, email, emailPassword);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetImageBytesAsync(int fileId)
        {
            return base.Channel.GetImageBytesAsync(fileId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetDistinctProprietyNamesAsync()
        {
            return base.Channel.GetDistinctProprietyNamesAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_interfaceClasses))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_interfaceClasses))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/IM");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return interfaceClassesClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_interfaceClasses);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return interfaceClassesClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_interfaceClasses);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_interfaceClasses,
        }
    }
}
