﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileService.FrameworkClient.Clients {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Clients.IFileService")]
    public interface IFileService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetServiceTime", ReplyAction="http://tempuri.org/IFileService/GetServiceTimeResponse")]
        System.DateTime GetServiceTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetServiceTime", ReplyAction="http://tempuri.org/IFileService/GetServiceTimeResponse")]
        System.Threading.Tasks.Task<System.DateTime> GetServiceTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetDrives", ReplyAction="http://tempuri.org/IFileService/GetDrivesResponse")]
        System.IO.DriveInfo[] GetDrives();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetDrives", ReplyAction="http://tempuri.org/IFileService/GetDrivesResponse")]
        System.Threading.Tasks.Task<System.IO.DriveInfo[]> GetDrivesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFiles", ReplyAction="http://tempuri.org/IFileService/GetFilesResponse")]
        System.IO.FileInfo[] GetFiles(string Path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetFiles", ReplyAction="http://tempuri.org/IFileService/GetFilesResponse")]
        System.Threading.Tasks.Task<System.IO.FileInfo[]> GetFilesAsync(string Path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetDirectories", ReplyAction="http://tempuri.org/IFileService/GetDirectoriesResponse")]
        System.IO.DirectoryInfo[] GetDirectories(string Path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/GetDirectories", ReplyAction="http://tempuri.org/IFileService/GetDirectoriesResponse")]
        System.Threading.Tasks.Task<System.IO.DirectoryInfo[]> GetDirectoriesAsync(string Path);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileServiceChannel : FileService.FrameworkClient.Clients.IFileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileServiceClient : System.ServiceModel.ClientBase<FileService.FrameworkClient.Clients.IFileService>, FileService.FrameworkClient.Clients.IFileService {
        
        public FileServiceClient() {
        }
        
        public FileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.DateTime GetServiceTime() {
            return base.Channel.GetServiceTime();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> GetServiceTimeAsync() {
            return base.Channel.GetServiceTimeAsync();
        }
        
        public System.IO.DriveInfo[] GetDrives() {
            return base.Channel.GetDrives();
        }
        
        public System.Threading.Tasks.Task<System.IO.DriveInfo[]> GetDrivesAsync() {
            return base.Channel.GetDrivesAsync();
        }
        
        public System.IO.FileInfo[] GetFiles(string Path) {
            return base.Channel.GetFiles(Path);
        }
        
        public System.Threading.Tasks.Task<System.IO.FileInfo[]> GetFilesAsync(string Path) {
            return base.Channel.GetFilesAsync(Path);
        }
        
        public System.IO.DirectoryInfo[] GetDirectories(string Path) {
            return base.Channel.GetDirectories(Path);
        }
        
        public System.Threading.Tasks.Task<System.IO.DirectoryInfo[]> GetDirectoriesAsync(string Path) {
            return base.Channel.GetDirectoriesAsync(Path);
        }
    }
}